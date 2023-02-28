using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace Project.Cfinal
{
    public partial class LoginForm : Form
    {
        Thread th;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public LoginForm()
        {
            InitializeComponent();
            PWbox.PasswordChar = '*';//(최익준) 비밀번호 '*' 표시
        }
        DBconn connect = DBconn.getInstance();

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

 
        private void IDbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Loginbot_Click_1(object sender, EventArgs e)
        {
            MainForm m1 = new MainForm();
            RootForm r1 = new RootForm();
            /*SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from 테이블명 where  user_id='" + IDbox.Text + "' and user_pw='" + PWbox.Text + "'", connect);
            //이게  테이블에서 같은거있는지 찾아서 같은게 있으면 숫자1씩늘어남
            DataTable newTable = new DataTable();
            sda.Fill(newTable);
            //
            SqlDataAdapter query1 = new SqlDataAdapter("Select User_serial from 테이블명 where user_id = '" + IDbox.Text + "'", connect);//connect 에러남 원인 모르겠음
            DataTable Table = new DataTable();
            query1.Fill(Table);
            int Num = int.Parse(Table.Rows[0][0].ToString());
            if (newTable.Rows[0][0].ToString() == "1" && Num >= 0 && Num <= 7 || IDbox.Text == "root" && PWbox.Text == "root") //대충 루트로 로그인 하는지 확인 하는 공간 
            {//유저 Serial이 0~7일경우 관리자 권한으로 로그인
                MessageBox.Show("관리자 모드로 로그인합니다.", "관리자 모드");
                this.Hide();
                r1.Show();
            }//이거 테이블명도 알아야되는데 필요하면 디코 채팅
            else if (newTable.Rows[0][0].ToString() == "1" || IDbox.Text == "user") // 대충 일반 사용자로 로그인 하는지 확인
            {
                MessageBox.Show("유저 모드로 로그인합니다.", "유저 모드");
                this.Hide();
                m1.Show();
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다. 다시 입력해주십시오.");//아이디 일치 하지 않으면 틀렸다고 창 표시(최익준) 이상하면 삭제 or 수정
                IDbox.Clear();
                PWbox.Clear();//이거는 텍스트박스 초기화 하는거
            }*/
            int i=sqluse.selLogin(IDbox.Text, PWbox.Text);
            if (i==0) //대충 루트로 로그인 하는지 확인 하는 공간 
            {//유저 Serial이 0~3일경우 관리자 권한으로 로그인
                MessageBox.Show("관리자 모드로 로그인합니다.", "관리자 모드");
                r1.Show();
                this.Hide();
                
            }//이거 테이블명도 알아야되는데 필요하면 디코 채팅
            else if (i==3) // 대충 일반 사용자로 로그인 하는지 확인
            {
                MessageBox.Show("유저 모드로 로그인합니다.", "유저 모드");
                m1.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다. 다시 입력해주십시오.");//아이디 일치 하지 않으면 틀렸다고 창 표시(최익준) 이상하면 삭제 or 수정
                IDbox.Clear();
                PWbox.Clear();//이거는 텍스트박스 초기화 하는거
            }
        }

        private void Forgotbot_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void Opennewform1()
        {
            Application.Run(new SignUpForm());
        }
        private void SignUpbot_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform()
        {
            Application.Run(new SignUpForm());
        }//샘플파일로는 잘되는데 107줄에서 에러나는거같긴한데 아까 하이드 뭐시기 들어가서 그런듯. 로그인 하이든데 새 로그인폼 생성시켜버리니까 그거 충돌나는듯
    }//Hide 말고 쓰레드를 줘서 폼을 구현하는걸로 찾아 왔는데 그걸로 실행?
}
