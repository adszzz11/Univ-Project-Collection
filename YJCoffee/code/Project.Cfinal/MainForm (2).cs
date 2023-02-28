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

        public MainForm()
        {
            InitializeComponent();
        }

        private void OrderGobot_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {   //캐쉬충전 버튼을 눌렀을때.
            /*MessageBox.Show("결재중........"); 
            캐쉬충전 과정까지 구현X 만약 구현할예정이라면 DB 유저 데이터에 캐쉬 항목 생성.
            디테일한 구현은 힘들테니 간단하게 Cash 폼 하나 만들어서 텍스트박스에
            충전 금액을 입력한 후 버튼을 누르면 다시 메인폼으로 돌아오게 구현. 충전 액수는 DB
            캐쉬 데이터에 더해지기 덮어쓰기 ㄴㄴ
            -- 몹시 간단한데 DB는 간단하련지 모르겠긴하네*/
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform()
        {
            Application.Run(new OrderForm());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void 주문하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
