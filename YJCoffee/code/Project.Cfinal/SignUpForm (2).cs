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
            pw2.PasswordChar = '*';
        }
       // DBconn d = DBconn.getInstance();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) from user where user_id='" + id.Text + "'", d);
            DataTable newTable = new DataTable();
           // sda.Fill(newTable);
            if (newTable.Rows[0][0].ToString() == "1")//아이디 중복체크
                MessageBox.Show("아이디 중복입니다.", "중복");
            else
            {
                MessageBox.Show("아이디를 생성할수있습니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pw.Text == pw2.Text)//비밀번호 확인
                MessageBox.Show("일치합니다.", "일치");
            else
                MessageBox.Show("일치하지않습니다.", "불일치");

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) from user where user_id='" + id.Text + "'", d);
            DataTable newTable = new DataTable();
           // sda.Fill(newTable);
            if (newTable.Rows[0][0].ToString() == "1")
                MessageBox.Show("아이디 중복체크를 확인하십시오");
            else if (pw.Text == pw2.Text) {
                MessageBox.Show("비밀번호가 일치하지않습니다.", "불일치");
                pw2.Clear();
            }
            else
            {
             //   d.Open();
              //  MySqlDataAdapter query1 = new MySqlDataAdapter("Select MAX(user_serial) from user", d);//유저 시리얼 번호 최댓값찾기
                DataTable Table = new DataTable();
              //  query1.Fill(Table);
                int Num = int.Parse(Table.Rows[0][0].ToString()) + 1;//찾은 시리얼번호에서 +1하기
                String query = "INSERT INTO user(user_id,user_pw,user_name,user_birth,user_QnA,user_phonenum,user_Answer,user_serial) VALUES(N'" + id.Text + "','" + pw.Text + "','" + name.Text + "'" + bir.Text + "','" + QnA.Text + "','" + answer.Text + "','" + phone.Text + "','" + Num + "') ";
              //  MySqlDataAdapter SDA = new MySqlDataAdapter(query, d);
               // SDA.SelectCommand.ExecuteNonQuery();
              //  d.Close();
                MessageBox.Show("아이디 생성에 성공하셧습니다.");
                this.Hide();
                MainForm M1 = new MainForm();
                M1.Show(); //회원가입하면 창이 닫기고 메인폼이 열림
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform()
        {
            Application.Run(new LoginForm());
        }//ok 내가 여기서 메인폼으로 연결했네앙 기먹디 나는 멍청이네 - ok 이제될듯ㅇㅋㅇㅋ이거 하이드 말고 아예 끄는거 없나 
    }
}
