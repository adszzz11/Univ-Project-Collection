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
    public partial class RootForm : Form
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
        public RootForm()
        {
            InitializeComponent();
            d.connect.Open();
            String query = "select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=0";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            orderView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = orderView.Rows.Add();
                orderView.Rows[n].Cells[0].Value = item["reservation_time"].ToString();
                orderView.Rows[n].Cells[1].Value = item["menu_name"].ToString();
                orderView.Rows[n].Cells[2].Value = item["reservation_detail"].ToString();
                orderView.Rows[n].Cells[3].Value = item["user_id"].ToString();
            }
            String query1 = "select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=1 and reservation_ready=0";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            makeView.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = makeView.Rows.Add();
                makeView.Rows[n].Cells[0].Value = item["reservation_time"].ToString();
                makeView.Rows[n].Cells[1].Value = item["menu_name"].ToString();
                makeView.Rows[n].Cells[2].Value = item["reservation_detail"].ToString();
                makeView.Rows[n].Cells[3].Value = item["user_id"].ToString();
            }
            d.connect.Close();
           /* DataSet ds = sqluse.printReserve();
            orderView.DataSource = ds.Tables[0];
            DataSet ds2 = sqluse.printReserve2();
            makeView.DataSource = ds2.Tables[0];*/
            timer1.Start();
            waitpeople.Text = "주문 대기자 수 : " + sqluse.getWaiting();
            orderedpeople.Text = "주문 신청자 수 : " + sqluse.getOrdered();
        }
        DBconn d = DBconn.getInstance();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menubot_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //로그인 화면으로 넘어가감 로그아웃
        }
        private void Opennewform()
        {
            Application.Run(new LoginForm());
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //메뉴 관리창 열기
            this.Close();
            th = new Thread(Opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform1()
        {
            Application.Run(new RootMenuForm());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void RootForm_Load(object sender, EventArgs e)
        {

        }

        private void Rootbookerbot_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //예약자 관리
        }
        private void Opennewform2()
        {
            Application.Run(new RootBookerForm());
        }

        private void orderCheck_Click(object sender, EventArgs e)
        {
            d.connect.Open();
            String query = "UPDATE reservation SET reservation_OK = '1'WHERE reservation_OK = '0'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            SDA.SelectCommand.ExecuteNonQuery();
            d.connect.Close();
            MessageBox.Show("주문 전부 확인", "확 인");//주문전부확인
            this.ResumeLayout(false);
            d.connect.Open();
            String query2 = "select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=0";
            MySqlDataAdapter SDA2 = new MySqlDataAdapter(query2, d.connect);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            orderView.Rows.Clear();
            foreach (DataRow item in dt2.Rows)
            {
                int n = orderView.Rows.Add();
                orderView.Rows[n].Cells[0].Value = item["reservation_time"].ToString();
                orderView.Rows[n].Cells[1].Value = item["menu_name"].ToString();
                orderView.Rows[n].Cells[2].Value = item["reservation_detail"].ToString();
                orderView.Rows[n].Cells[3].Value = item["user_id"].ToString();
            }
            String query1 = "select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=1 and reservation_ready=0";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            makeView.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = makeView.Rows.Add();
                makeView.Rows[n].Cells[0].Value = item["reservation_time"].ToString();
                makeView.Rows[n].Cells[1].Value = item["menu_name"].ToString();
                makeView.Rows[n].Cells[2].Value = item["reservation_detail"].ToString();
                makeView.Rows[n].Cells[3].Value = item["user_id"].ToString();
            }
            d.connect.Close();
            waitpeople.Text = "주문 대기자 수 : " + sqluse.getWaiting();
            orderedpeople.Text = "주문 신청자 수 : " + sqluse.getOrdered();
        }

        private void makeCheck_Click(object sender, EventArgs e)
        {
            d.connect.Open();
            String query = "UPDATE reservation SET reservation_Ready = '1'WHERE reservation_Ready = '0' and reservation_OK = '1'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            SDA.SelectCommand.ExecuteNonQuery();
            d.connect.Close();
            MessageBox.Show("제작 전부 확인", "확 인");//제작전부확인
            this.ResumeLayout(false);
            d.connect.Open();
            String query2 = "select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=0";
            MySqlDataAdapter SDA2 = new MySqlDataAdapter(query2, d.connect);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            orderView.Rows.Clear();
            foreach (DataRow item in dt2.Rows)
            {
                int n = orderView.Rows.Add();
                orderView.Rows[n].Cells[0].Value = item["reservation_time"].ToString();
                orderView.Rows[n].Cells[1].Value = item["menu_name"].ToString();
                orderView.Rows[n].Cells[2].Value = item["reservation_detail"].ToString();
                orderView.Rows[n].Cells[3].Value = item["user_id"].ToString();
            }
            String query1 = "select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=1 and reservation_ready=0";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            makeView.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = makeView.Rows.Add();
                makeView.Rows[n].Cells[0].Value = item["reservation_time"].ToString();
                makeView.Rows[n].Cells[1].Value = item["menu_name"].ToString();
                makeView.Rows[n].Cells[2].Value = item["reservation_detail"].ToString();
                makeView.Rows[n].Cells[3].Value = item["user_id"].ToString();
            }
            d.connect.Close();
            waitpeople.Text = "주문 대기자 수 : " + sqluse.getWaiting();
            orderedpeople.Text = "주문 신청자 수 : " + sqluse.getOrdered();
        }
    }
}