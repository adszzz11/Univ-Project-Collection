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
    public partial class RootForm : Form
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
        public RootForm()
        {
            InitializeComponent();
            DataSet ds = sqluse.printReserve();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menubot_Click(object sender, EventArgs e)
        {
            //메뉴 관리창 열기
            RootMenuForm R1 = new RootMenuForm();
            MessageBox.Show("메뉴 관리를 시작합니다.","메뉴 관리");//텍스트박스 변경 가능
            this.Hide();
            R1.Show();
        }

        private void ToLogin_Click(object sender, EventArgs e)//로그인화면
        {
           
        }

        private void Userbot_Click(object sender, EventArgs e)//사용자관리이 뭔지 모르겠음 
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //예약자 관리창 열기 데이터 연결 가아능?
        }
    }
}
