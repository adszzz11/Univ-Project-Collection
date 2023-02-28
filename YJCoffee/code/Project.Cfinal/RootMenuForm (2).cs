using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Cfinal
{
    public partial class RootMenuForm : Form
    {
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
        public RootMenuForm()
        {
            InitializeComponent();
            DataSet ds = sqluse.printMenuOP();
            dataGridView2.DataSource = ds.Tables[0];
            ds = sqluse.printMenuOP_using();
            dataGridView1.DataSource = ds.Tables[0];
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yg050\Documents\Data1.mdf;Integrated Security=True;Connect Timeout=30");
        private void NowMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RootMenuForm_Load(object sender, EventArgs e)
        {

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