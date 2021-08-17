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
using System.Drawing.Text;

namespace Project.Cfinal
{
    public partial class MainForm : Form
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
        DBconn d = DBconn.getInstance();
        public MainForm()
        {
            InitializeComponent();
        }

       
        private void goOrderForm_Click(object sender, EventArgs e) //OrderForm창으로 이동
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform() 
        {
            Application.Run(new OrderForm()); //OrderForm 런 메서드 생성
        }
      

        private void goCashForm_Click(object sender, EventArgs e)
        {
            CashForm cs = new CashForm(this);
            cs.Show();
            //잔액 충전 창 띄우기
        }

        private void Opennewform1()
        {
            Application.Run(new LoginForm()); // LoginForm 런 매서드 생성
        }

    
        public void loading() 
        {
            moneytext.Text = "" + sqluse.getUserMoney(LoginForm.getUserSerial());
        }
        public void reloading()
        {
            moneytext.Text = "" + sqluse.getUserMoney(LoginForm.getUserSerial());
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            nametext.Text = sqluse.getUserName(LoginForm.getUserSerial());
            moneytext.Text = "" + sqluse.getUserMoney(LoginForm.getUserSerial());
            /*DataSet ds = sqluse.printReserve();
            UserMainView.DataSource = ds.Tables[0];*/
            String query = "select reservation_time, menu_name, reservation_detail, user_id ,reservation_ready ,reservation_OK from reservation where user_id='" + sqluse.getUserName(LoginForm.getUserSerial()) + "';";
            d.connect.Open();
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            UserMainView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = UserMainView.Rows.Add();
                UserMainView.Rows[n].Cells[0].Value = item["reservation_time"].ToString();
                UserMainView.Rows[n].Cells[1].Value = item["menu_name"].ToString();
                UserMainView.Rows[n].Cells[2].Value = item["reservation_detail"].ToString();
                UserMainView.Rows[n].Cells[3].Value = item["user_id"].ToString();
                UserMainView.Rows[n].Cells[4].Value = item["reservation_ready"].ToString();
                UserMainView.Rows[n].Cells[5].Value = item["reservation_OK"].ToString();
            }
            d.connect.Close();
        }
        private void goLoginForm_Click(object sender, EventArgs e) //LoginForm화면으로 이동
        {
            this.Close();
            th = new Thread(Opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
     
        private void Opennewform3()
        {
            Application.Run(new ProFileEdit()); // ProFileEdit 런 메서드 생성
        }

    

        private void goUserProfile_Click_1(object sender, EventArgs e) // ProFileEdit 창으로 이동
        {
            this.Close();
            th = new Thread(Opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}