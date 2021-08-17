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
    public partial class RootMenuForm : Form
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
        public void refresh() {
            d.connect.Open();
            String query = "SELECT * FROM menu where menu_activate=1";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            nowsellView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = nowsellView.Rows.Add();
                nowsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                nowsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                nowsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();
            d.connect.Open();
            String query1 = "SELECT * FROM menu where menu_activate=0";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            notsellView.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = notsellView.Rows.Add();
                notsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                notsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                notsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();
        }
        public RootMenuForm()
        {
            InitializeComponent();
            refresh();
            /*d.connect.Open();
            String query = "SELECT * FROM menu where menu_activate=1";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            nowsellView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = nowsellView.Rows.Add();
                nowsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                nowsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                nowsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();
            d.connect.Open();
            String query1 = "SELECT * FROM menu where menu_activate=0";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            notsellView.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = notsellView.Rows.Add();
                notsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                notsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                notsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();*/
            /*InitializeComponent();
            DataSet ds = sqluse.printMenuOP();
            notsellView.DataSource = ds.Tables[0];
            DataSet ds2 = sqluse.printMenuOP_using();
            nowsellView.DataSource = ds2.Tables[0];*/
        }
        DBconn d = DBconn.getInstance();
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yg050\Documents\Data1.mdf;Integrated Security=True;Connect Timeout=30");
        private void NowMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RootMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void ToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //로그인 창으로 이동
        }
        private void Opennewform()
        {
            Application.Run(new LoginForm()); // LoginForm 런 매서드 생성
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
            Application.Run(new RootForm()); // RootForm 런 매서드 생성
        }
        private void addmenu_Click(object sender, EventArgs e) //메뉴추가
        {
            int num;
            if (Stock.Text == "품절")
                num = 1;
            else
                num = 0;
            MySqlDataAdapter query1 = new MySqlDataAdapter("Select MAX(menu_serial) from menu", d.connect);//유저 시리얼 번호 최댓값찾기
            DataTable Table = new DataTable();
            query1.Fill(Table);
            int Num = int.Parse(Table.Rows[0][0].ToString()) + 1;//찾은 시리얼번호에서 +1하기
            d.connect.Open();
            String query = "INSERT INTO Menu(menu_name,menu_price,menu_done,menu_serial) VALUES('" + menutext.Text + "','" + menuprice.Text + "','" + num + "','" + Num + "') ";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            SDA.SelectCommand.ExecuteNonQuery();
            d.connect.Close();
            MessageBox.Show("메뉴 추가 성공", "성공");
            refresh();
            /*d.connect.Open();
            String query2 = "SELECT * FROM menu where menu_activate=1";
            MySqlDataAdapter SDA2 = new MySqlDataAdapter(query2, d.connect);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            nowsellView.Rows.Clear();
            foreach (DataRow item in dt2.Rows)
            {
                int n = nowsellView.Rows.Add();
                nowsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                nowsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                nowsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            String query3 = "SELECT * FROM menu where menu_activate=0";
            MySqlDataAdapter SDA3 = new MySqlDataAdapter(query3, d.connect);
            DataTable dt3 = new DataTable();
            SDA3.Fill(dt3);
            notsellView.Rows.Clear();
            foreach (DataRow item in dt3.Rows)
            {
                int n = notsellView.Rows.Add();
                notsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                notsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                notsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();*/
            //메뉴 추가 버튼
        }

        private void activenoactive_Click(object sender, EventArgs e) //메뉴 활성화/비활성화
        {
            d.connect.Open();
            MySqlDataAdapter SDA = new MySqlDataAdapter("Select Count(*) from Menu where  menu_activate=0 and menu_name='" + menutext.Text + "'", d.connect);
            DataTable Table = new DataTable();
            SDA.Fill(Table);
            d.connect.Close();
            if (Table.Rows[0][0].ToString() == "1")//1활성 0비활성       0 안품절 1 품절
            {
                d.connect.Open();
                String query0 = "UPDATE Menu SET menu_activate = 1 WHERE menu_name = '" + menutext.Text + "'";
                MySqlDataAdapter SDA0 = new MySqlDataAdapter(query0, d.connect);
                SDA0.SelectCommand.ExecuteNonQuery();
                d.connect.Close();
                MessageBox.Show("메뉴 활성화 성공", "성공");
            }
            else
            {
                d.connect.Open();
                String query3 = "UPDATE Menu SET menu_activate = 0 WHERE menu_name = '" + menutext.Text + "'";
                MySqlDataAdapter SDA3 = new MySqlDataAdapter(query3, d.connect);
                SDA3.SelectCommand.ExecuteNonQuery();
                d.connect.Close();
                MessageBox.Show("메뉴 비활성화 성공", "성공");
            }
            refresh();
            /*d.connect.Open();
            String query = "SELECT * FROM menu where menu_activate=1";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query, d.connect);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            nowsellView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = nowsellView.Rows.Add();
                nowsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                nowsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                nowsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            String query4 = "SELECT * FROM menu where menu_activate=0";
            MySqlDataAdapter SDA4 = new MySqlDataAdapter(query4, d.connect);
            DataTable dt4 = new DataTable();
            SDA4.Fill(dt4);
            notsellView.Rows.Clear();
            foreach (DataRow item in dt4.Rows)
            {
                int n = notsellView.Rows.Add();
                notsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                notsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                notsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();*/
            //메뉴 삭제 버튼
        }

        private void MenuSetbot_Click(object sender, EventArgs e) //메뉴 수정
        {
            int num;
            if (Stock.Text == "품절")
                num = 1;
            else
                num = 0;
            d.connect.Open();
            /*
            DataTable table = new DataTable();
            //MySqlDataReader table = command.ExecuteReader();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);*/
            String query00 = "select menu_serial from menu where menu_name = '" +  temp +  "';";
            MySqlCommand command = new MySqlCommand(query00, d.connect);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            int result = Int32.Parse(table.Rows[0][0].ToString());
            String query = "UPDATE menu SET menu_name = '"+menutext.Text+"', menu_price = " + menuprice.Text + ", menu_done = " + num + " WHERE menu_serial = " + result + ";";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            SDA.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("메뉴 수정 성공", "성공");
            String query1 = "SELECT * FROM menu where menu_activate=1";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            nowsellView.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = nowsellView.Rows.Add();
                nowsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                nowsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                nowsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            String query2 = "SELECT * FROM menu where menu_activate=0";
            MySqlDataAdapter SDA2 = new MySqlDataAdapter(query2, d.connect);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            notsellView.Rows.Clear();
            foreach (DataRow item in dt2.Rows)
            {
                int n = notsellView.Rows.Add();
                notsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                notsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                notsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();
            //메뉴 수정 버튼
        }

        private void soldout_Click(object sender, EventArgs e) //품절
        {
            d.connect.Open();
            int num;
            if (Stock.Text == "품절")
                num = 0;
            else
                num  =  1;
            String query = "UPDATE Menu SET menu_done = '"+num+"' WHERE menu_name = '" + menutext.Text + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, d.connect);
            SDA.SelectCommand.ExecuteNonQuery();
            String query1 = "SELECT * FROM menu where menu_activate=1";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            nowsellView.Rows.Clear();
            foreach (DataRow item in dt1.Rows)
            {
                int n = nowsellView.Rows.Add();
                nowsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                nowsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                nowsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            String query2 = "SELECT * FROM menu where menu_activate=0";
            MySqlDataAdapter SDA2 = new MySqlDataAdapter(query2, d.connect);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            notsellView.Rows.Clear();
            foreach (DataRow item in dt2.Rows)
            {
                int n = notsellView.Rows.Add();
                notsellView.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                notsellView.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                notsellView.Rows[n].Cells[2].Value = item["menu_done"].ToString();
            }
            d.connect.Close();
            if (num == 1)
                MessageBox.Show("품절되었습니다.");
            else
                MessageBox.Show("판매를 재시작합니다.");
            //메뉴 확인 버튼
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //예약자 현황 창으로
        }
        private void Opennewform2()
        {
            Application.Run(new RootBookerForm());
        }
        static String temp;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            menutext.Text = notsellView.SelectedRows[0].Cells[0].Value.ToString();
            temp = menutext.Text;
            menuprice.Text = notsellView.SelectedRows[0].Cells[1].Value.ToString();
            if (notsellView.SelectedRows[0].Cells[2].Value.ToString() == "1")
                Stock.Text = "품절";
            else
                Stock.Text = "재고있음";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //+++++++++++++++++++++++++++++++++textBox5.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            menutext.Text = nowsellView.SelectedRows[0].Cells[0].Value.ToString();
            menuprice.Text = nowsellView.SelectedRows[0].Cells[1].Value.ToString();
            if(nowsellView.SelectedRows[0].Cells[2].Value.ToString()=="1")
                 Stock.Text  =  "품절";
            else
                Stock.Text = "재고있음";

        }
        /*private void RootMenuForm_Load(object sender, EventArgs e)
{
// TODO: 이 코드는 데이터를 'data1DataSet1.RootMenu' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
this.rootMenuTableAdapter1.FillBy1(this.data1DataSet1.RootMenu);
// TODO: 이 코드는 데이터를 'data1DataSet.RootMenu' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
this.rootMenuTableAdapter.FillBy(this.data1DataSet.RootMenu);

}

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
textBox6.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
}

private void label6_Click(object sender, EventArgs e)
{

}

private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{

}

private void button5_Click(object sender, EventArgs e)
{

}

private void button4_Click(object sender, EventArgs e)
{
this.rootMenuTableAdapter1.FillBy1(this.data1DataSet1.RootMenu);
this.rootMenuTableAdapter.FillBy(this.data1DataSet.RootMenu);
}

private void button3_Click(object sender, EventArgs e)
{

}

private void label4_Click(object sender, EventArgs e)
{

}

private void label5_Click(object sender, EventArgs e)
{

}

private void button2_Click(object sender, EventArgs e)
{
con.Open();
String query = "INSERT INTO RootMenu(Menu,Price,Stock) VALUES(N'" + textBox5.Text + "','" + textBox6.Text + "',N'" + comboBox1.Text + "') ";
SqlDataAdapter SDA = new SqlDataAdapter(query, con);
SDA.SelectCommand.ExecuteNonQuery();
con.Close();
MessageBox.Show("메뉴 추가 성공", "성공");
}

private void textBox3_TextChanged(object sender, EventArgs e)
{

}

private void textBox4_TextChanged(object sender, EventArgs e)
{

}

private void textBox5_TextChanged(object sender, EventArgs e)
{

}

private void label3_Click(object sender, EventArgs e)
{

}

private void MenuSetbot_Click(object sender, EventArgs e)
{
con.Open();
String query = "UPDATE RootMenu SET Price = '" + textBox6.Text + "', Stock = N'" + comboBox1.Text + "' WHERE Menu = N'" + textBox5.Text + "'";
SqlDataAdapter SDA = new SqlDataAdapter(query, con);
SDA.SelectCommand.ExecuteNonQuery();
con.Close();
MessageBox.Show("메뉴 수정 성공", "성공");
}

private void CellDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
{
}

private void fillByToolStripButton_Click(object sender, EventArgs e)
{
try
{
this.rootMenuTableAdapter.FillBy(this.data1DataSet.RootMenu);
}
catch (System.Exception ex)
{
System.Windows.Forms.MessageBox.Show(ex.Message);
}

}
private void fillBy1ToolStripButton_Click_2(object sender, EventArgs e)
{
try
{
this.rootMenuTableAdapter1.FillBy1(this.data1DataSet1.RootMenu);
}
catch (System.Exception ex)
{
System.Windows.Forms.MessageBox.Show(ex.Message);
}

}

private void fillByToolStripButton_Click_2(object sender, EventArgs e)
{
try
{
this.rootMenuTableAdapter.FillBy(this.data1DataSet.RootMenu);
}
catch (System.Exception ex)
{
System.Windows.Forms.MessageBox.Show(ex.Message);
}

}
private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
{
textBox5.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
textBox6.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
}*/
    }
}