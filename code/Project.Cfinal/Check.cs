using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Cfinal
{
    public partial class Check : Form
    {
        MainForm ma;
        public Check()
        {
            InitializeComponent();

        }
        public Check(MainForm main) 
        {
            InitializeComponent();
            ma = main;
        }
        
        private void Check_Load(object sender, EventArgs e)
        {
            label1.Text = CashForm.getMoney() + "원을 충전하시겠습니까?";
        }

        




        private void nobutton_Click_1(object sender, EventArgs e) // 아니오를 눌렀을 경우
        {
            this.Close(); // 창을 닫음
        }

        private void yesbutton_Click_1(object sender, EventArgs e) // 예를 눌렀을 경우
        {
            int cash;
            if (CashForm.getMoney().Equals("")) // 금액칸이 비어있을때
            {
                MessageBox.Show("금액이 입력되지 않았습니다.");
                this.Close();
            }
            else 
            {
                cash = Convert.ToInt32(CashForm.getMoney()); // 정수 cash에 입력한 돈 값을 불러옴.
                sqluse.plusMoney(LoginForm.getUserSerial(), cash);//cash 값을 유저 DB값에 더하기
                ma.reloading();
                MessageBox.Show("충전이 완료되었습니다.");
                this.Close();
            }
        }
    }
}
