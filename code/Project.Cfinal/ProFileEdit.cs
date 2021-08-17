using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Cfinal
{
    public partial class ProFileEdit : Form
    {
        Thread th;
        public ProFileEdit()
        {
            InitializeComponent();
        }
        Boolean check = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }
               

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ProFileEdit_Load(object sender, EventArgs e) //ProFileEdit 불러왔을때 기본정보 입력
        {
            id.Text = sqluse.getID(LoginForm.getUserSerial());
            birth.Text = sqluse.getBirth(LoginForm.getUserSerial());
            phonenum.Text = sqluse.getPhone(LoginForm.getUserSerial());
            nametextBox.Text = sqluse.getName(LoginForm.getUserSerial());
        }
        private void myTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkpwbutton_Click(object sender, EventArgs e)
        {
            if (pwtextbox.Text == checkpwtextbox.Text&&pwtextbox.Text!="")
            {
                MessageBox.Show("확인되었습니다.");
                check = true;

            }
            else
                MessageBox.Show("다시 확인해주세요.");
        }

        private void Savebot_Click(object sender, EventArgs e)
        {
            if (check == true && phonenum.Text != "" && nametextBox.Text != "" && pwtextbox.Text == checkpwtextbox.Text)
            {
                sqluse.updateUser(checkpwtextbox.Text, nametextBox.Text, phonenum.Text, LoginForm.getUserSerial());
                // 바뀐 비밀번호, 이름 , 전화번호 ,비밀번호 저장하는 DB문 .
                pwtextbox.Text = string.Empty;
                phonenum.Text = string.Empty;
                nametextBox.Text = string.Empty;
                checkpwtextbox.Text = String.Empty;
            }
            else
                MessageBox.Show("비밀번호 확인을누르거나 정보를 다시한번 확인해 주십시오.");
        }

        private void Tomain_Click(object sender, EventArgs e) // MainForm으로 이동
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Opennewform()
        {
            Application.Run(new MainForm()); //MainForm 런 매서드 생성
        }
    }
}

