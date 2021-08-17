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
        DBconn d = DBconn.getInstance();
        private static int user_serial; //전역변수 설정
        
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
            PWbox.PasswordChar = '*';//비밀번호 '*' 표시
        }
        private void Loginbot_Click_1(object sender, EventArgs e)
        {
            MainForm m1 = new MainForm();
            RootForm r1 = new RootForm();
            
            int i=sqluse.selLogin(IDbox.Text, PWbox.Text); //정보가 제대로 쳐졌는지 확인
            if (i==0) // 루트로 로그인 하는지 확인 
            {//유저 Serial이 0~3일경우 관리자 권한으로 로그인
                MessageBox.Show("관리자 모드로 로그인합니다.", "관리자 모드");
                r1.Show();
                this.Hide();
                
            }
            else if (i==3) // 대충 일반 사용자로 로그인 하는지 확인
            {
                MessageBox.Show("유저 모드로 로그인합니다.", "유저 모드");
                m1.Show();
                this.Hide();     
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다. 다시 입력해주십시오.");//아이디 일치 하지 않으면 틀렸다고 창 표시 
                IDbox.Clear();
                PWbox.Clear();//이거는 텍스트박스 초기화 하는거
            }
        }
        private void SignUpbot_Click(object sender, EventArgs e) // signupform으로 이동
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform()
        {
            Application.Run(new SignUpForm()); // signupform 런 매서드 생성
        }
        
        private void Exitbot_Click(object sender, EventArgs e)
        {
            this.Close();
            //종료 버튼
        }

        private void FindPwForm_Click(object sender, EventArgs e) // findpwForm 창으로 이동
        {
            this.Close();
            th = new Thread(Opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform2()
        {
            Application.Run(new FindPwForm()); // findpwForm 런 매서드 생성
        }
        public static int getUserSerial()
        {
            return user_serial;
        }
        public static void setUserSerial(int serial)
        {
            user_serial=serial;
        }
    }
}