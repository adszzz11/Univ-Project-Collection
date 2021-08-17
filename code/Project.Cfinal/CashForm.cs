using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
namespace Project.Cfinal
{
    public partial class CashForm : Form
    {
        Thread th;
        public static String a; // 체크폼에서 라벨에 얼마인지 적어주기위한 전역변수
        public CashForm()
        {
            InitializeComponent();
            nowcash.ReadOnly = true; // 현재잔액을 읽기만 가능하게 표시
            wantcash.MaxLength = 10; // cash 충전할때 10자리이상은 불가
        }

        MainForm main;
        public CashForm(MainForm ma) 
        {
            InitializeComponent();
            nowcash.ReadOnly = true; // 현재잔액을 읽기만 가능하게 표시
            wantcash.MaxLength = 10; // cash 충전할때 10자리이상은 불가
            main = ma;

        }


        

        private void ToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //로그아웃 후 로그인 화면으로 화면변경
        }
        private void Opennewform1()
        {
            Application.Run(new LoginForm()); //로그인폼 런매서드 생성
        }
        private void ToRootForm_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //메인 화면으로 화면변경
        }
        private void Opennewform()
        {
            Application.Run(new MainForm()); // 메인폼 런매서드 생성
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            // 주문화면으로 화면변경
        }
        private void Opennewform2()
        {
            Application.Run(new OrderForm()); 
        }
        

        private void goCashForm_Click(object sender, EventArgs e)
        {
            String money = wantcash.Text;
            String temp = Regex.Replace(money, @"\D", ""); // 문자열에서 숫자만 추출
            a = temp; // 전역변수에 숫자문자열 집어넣기.
            Check ch = new Check(this.main);
            ch.Show();
        }
        public static String getMoney()
        {
            return a;
        }
        private void showmoney_Click(object sender, EventArgs e)
        {
            String s;
            int m;
            //m = DB에 있는 유저의 현재 잔액. 
            m = sqluse.getUserMoney(LoginForm.getUserSerial()); //m = DB에 있는 유저의 현재 잔액.
            //s = Convert.ToString(m); //정수인 m을 문자열로 바꾸어주는 과정.
            nowcash.Text = m + "원"; //잔액을 표시. 
        }

        
    }
}
