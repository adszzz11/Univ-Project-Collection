using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
namespace Project.Cfinal
{
    public partial class FindPwForm : Form
    {
        Thread th;
        public FindPwForm()
        {
            InitializeComponent();
        }
        DBconn d = DBconn.getInstance();
        private void Loginbot_Click(object sender, EventArgs e) 
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //로그인 창으로
        }
        private void Opennewform()
        {
            Application.Run(new LoginForm()); //로그인폼 런 매서드
        }
        private void Findidbot_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namebox.Text) || String.IsNullOrWhiteSpace(numberbox.Text)) // 아이디나 전화번호중 빈칸이 있나 확인
            {
                MessageBox.Show("올바르게 작성되었는지 확인해주십시오");
            }
            else
            {
                int result = sqluse.findID(namebox.Text, numberbox.Text); // id랑 번호확인후 결과출력
                if (result!=1) // 실패시
                {
                    MessageBox.Show("이름과 전화번호를 확인해 주십시오", "실 패");
                    namebox.Clear();
                    numberbox.Clear();
                }
            }
        }

        private void Findpwbot_Click(object sender, EventArgs e) //비밀번호 찾기를 눌렀을때 
        {
            if (String.IsNullOrWhiteSpace(namebox2.Text) || String.IsNullOrWhiteSpace(numberbox2.Text) || String.IsNullOrWhiteSpace(idbox.Text)) 
                // 이름 아이디 전화번호에 빈칸이 있나 확인
            {
                MessageBox.Show("올바르게 작성되었는지 확인해주십시오");
            }
            else
            {
                int result=sqluse.findPW(idbox.Text, namebox2.Text, numberbox2.Text);//아이디 비밀번호 전화번호 확인후 결과출력
                if (result != 1) // 실패시
                {
                    MessageBox.Show("아이디, 이름, 전화번호를 확인해 주십시오", "실 패");
                    namebox.Clear();
                    numberbox.Clear();
                }
            }
        }
    }
}
