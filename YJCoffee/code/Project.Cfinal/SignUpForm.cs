using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
namespace Project.Cfinal
{
    public partial class SignUpForm : Form
    {
        Thread th;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        DBconn d = DBconn.getInstance();
        int result;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public SignUpForm()
        {
            InitializeComponent();
            pw.PasswordChar = '*'; //pw *로 표시
            pw2.PasswordChar = '*';
        }
        private void id_check_Click(object sender, EventArgs e)
        {
            result=sqluse.checkID(id.Text);
            if (result == 1)//아이디 중복체크
                this.id.ReadOnly = true;
        }

        private void pw_check_Click(object sender, EventArgs e) //pw와 pw2에쳐진게 같은지 확인
        {
            if (pw.Text.Equals(pw2.Text))
                MessageBox.Show("일치합니다.", "일치");
            else
                MessageBox.Show("일치하지않습니다.", "불일치");

        }

        private void make_user_Click(object sender, EventArgs e) // 아이디 생성버튼을 눌렀을때
        {
            if(result!=1)
            {
                MessageBox.Show("아이디 중복체크를 확인하십시오.");
                result = 0;
            }
            else if(!pw.Text.Equals(pw2.Text))
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "불일치");
                pw2.Clear();
            }
            else
            {
                if (String.IsNullOrWhiteSpace(id.Text) || String.IsNullOrWhiteSpace(pw.Text) || String.IsNullOrWhiteSpace(name.Text)
                    || String.IsNullOrWhiteSpace(phone.Text)) // 아이디 비밀번호 이름 폰번호가 비워졌는지 확인
                {
                    MessageBox.Show("올바르게 작성되었는지 확인해주십시오");
                }
                else
                {
                    int result  =  sqluse.insertUser(id.Text, pw.Text, name.Text, bir.Text, phone.Text); //DB에 자료를 넣음
                    if (result == 1)
                    {
                        this.Hide();
                        LoginForm L1 = new LoginForm();
                        L1.Show(); //회원가입하면 창이 닫기고 로그인폼이 열림
                    }
                    else
                    {
                        MessageBox.Show("아이디 생성에 실패하였습니다.");
                    }
                }
            }
        }

        private void Loginbot_Click(object sender, EventArgs e)//로그인 폼으로 이동
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform()
        {
            Application.Run(new LoginForm());
        }
    }
}
