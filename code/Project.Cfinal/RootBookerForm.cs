using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
namespace Project.Cfinal
{
    public partial class RootBookerForm : Form
    {
        Thread th;
        public RootBookerForm()
        {
            InitializeComponent();
            d.connect.Open();
             String query = "select * from reservation";
             MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
             DataTable dt = new DataTable();
             SDA.Fill(dt);
             menuView.Rows.Clear();
             foreach (DataRow item in dt.Rows)
             {
                 int n = menuView.Rows.Add();
                menuView.Rows[n].Cells[0].Value = item["reservation_serial"].ToString();
                menuView.Rows[n].Cells[1].Value = item["reservation_time"].ToString();
                menuView.Rows[n].Cells[2].Value = item["menu_name"].ToString();
                menuView.Rows[n].Cells[3].Value = item["reservation_detail"].ToString();
                menuView.Rows[n].Cells[4].Value = item["reservation_count"].ToString();
                menuView.Rows[n].Cells[5].Value = item["user_id"].ToString();
                menuView.Rows[n].Cells[6].Value = item["reservation_ready"].ToString();
                menuView.Rows[n].Cells[7].Value = item["reservation_OK"].ToString();
            }
             d.connect.Close();
            /*DataSet ds = sqluse.printReserveAll();
            menuView.DataSource = ds.Tables[0];*/

        }

        DBconn d = DBconn.getInstance();

        private void ToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //로그아웃 후 로그인폼
        }
        private void Opennewform()
        {
            Application.Run(new LoginForm());
        }
        private void ToRootForm_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //관리자 메인 폼으로 이동
        }
        private void Opennewform1()
        {
            Application.Run(new RootForm());
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //관리자 메뉴 관리 폼으로 이동
        }
        private void Opennewform2()
        {
            Application.Run(new RootMenuForm());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reservation_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ordernum.Text)) MessageBox.Show("주문번호를 확인해주세요.");
            else
            {
                d.connect.Open();
                String query = "update reservation set reservation_OK=1 where reservation_serial =" + ordernum.Text;
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("예약 접수 성공", "성공");//예약 접수
                String query1 = "select * from reservation";
                MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
                DataTable dt1 = new DataTable();
                SDA1.Fill(dt1);
                menuView.Rows.Clear();
                foreach (DataRow item in dt1.Rows)
                {
                    int n = menuView.Rows.Add();
                    menuView.Rows[n].Cells[0].Value = item["reservation_serial"].ToString();
                    menuView.Rows[n].Cells[1].Value = item["reservation_time"].ToString();
                    menuView.Rows[n].Cells[2].Value = item["menu_name"].ToString();
                    menuView.Rows[n].Cells[3].Value = item["reservation_detail"].ToString();
                    menuView.Rows[n].Cells[4].Value = item["reservation_count"].ToString();
                    menuView.Rows[n].Cells[5].Value = item["user_id"].ToString();
                    menuView.Rows[n].Cells[6].Value = item["reservation_ready"].ToString();
                    menuView.Rows[n].Cells[7].Value = item["reservation_OK"].ToString();
                }
                d.connect.Close();
            }
        }

        private void reservation_Reject_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ordernum.Text)) MessageBox.Show("주문번호를 확인해주세요.");
            else
            {
                d.connect.Open();
                String query = "update reservation set reservation_OK=3 where reservation_serial =" + ordernum.Text;//예약 거절 버튼을 누르면 reservayion_OK에 1를 입력함 1이 거절
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("예약 거절 성공", "거 절");
                String query1 = "select * from reservation";
                MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
                DataTable dt1 = new DataTable();
                SDA1.Fill(dt1);
                menuView.Rows.Clear();
                foreach (DataRow item in dt1.Rows)
                {
                    int n = menuView.Rows.Add();
                    menuView.Rows[n].Cells[0].Value = item["reservation_serial"].ToString();
                    menuView.Rows[n].Cells[1].Value = item["reservation_time"].ToString();
                    menuView.Rows[n].Cells[2].Value = item["menu_name"].ToString();
                    menuView.Rows[n].Cells[3].Value = item["reservation_detail"].ToString();
                    menuView.Rows[n].Cells[4].Value = item["reservation_count"].ToString();
                    menuView.Rows[n].Cells[5].Value = item["user_id"].ToString();
                    menuView.Rows[n].Cells[6].Value = item["reservation_ready"].ToString();
                    menuView.Rows[n].Cells[7].Value = item["reservation_OK"].ToString();
                }
                //String query1 = "select user_id from reservation where reservation_serial ="+ordernum.Text;
                //select menu_price from menu where menu_name=(select menu_name from reservation where reservation_serial=6);
                //MySqlCommand command = new MySqlCommand(query1, d.connect);
                //DataTable table = new DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                //adapter.Fill(table);
                //String ID = table.Rows[0][0].ToString()
                //int num= 
                /*String query2 = "update user set user_money = user_money+"+num+" where user_id=(select user_id from reservation where reservation_serial='"+ordernum.Text"');
                MySqlDataAdapter SDA = new MySqlDataAdapter(query2, d.connect);
                SDA.SelectCommand.ExecuteNonQuery();
                */
                d.connect.Close();
                sqluse.getUserName(LoginForm.getUserSerial());
                //예약 거절
            }
        }

        private void complete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ordernum.Text)) MessageBox.Show("주문번호를 확인해주세요.");
            else
            {
                d.connect.Open();
                String query = "update reservation set reservation_Ready='1' where reservation_serial ='" + ordernum.Text + "'";
                MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("메뉴 완성", "완성");
                String query1 = "select * from reservation";
                MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
                DataTable dt1 = new DataTable();
                SDA1.Fill(dt1);
                menuView.Rows.Clear();
                foreach (DataRow item in dt1.Rows)
                {
                    int n = menuView.Rows.Add();
                    menuView.Rows[n].Cells[0].Value = item["reservation_serial"].ToString();
                    menuView.Rows[n].Cells[1].Value = item["reservation_time"].ToString();
                    menuView.Rows[n].Cells[2].Value = item["menu_name"].ToString();
                    menuView.Rows[n].Cells[3].Value = item["reservation_detail"].ToString();
                    menuView.Rows[n].Cells[4].Value = item["reservation_count"].ToString();
                    menuView.Rows[n].Cells[5].Value = item["user_id"].ToString();
                    menuView.Rows[n].Cells[6].Value = item["reservation_ready"].ToString();
                    menuView.Rows[n].Cells[7].Value = item["reservation_OK"].ToString();
                }
                d.connect.Close();
                //완료
            }
        }

        private void RootBookerForm_Load(object sender, EventArgs e)
        {

        }

        private void menuView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
