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
    public partial class OrderForm : Form
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
        public OrderForm()
        {
            InitializeComponent();
            Orderbot.Click += orderbotclick; //주문하기 클릭 매서드생성
        }

        private void orderbotclick(object sender, EventArgs e)
        {
            String s = "";
            if (OrderMenuList.CheckedItems.Count != 0)
            {
                for (int x = 0; x < OrderMenuList.CheckedItems.Count; x++)
                {
                    s = s + "주문하신 상품인 " + OrderMenuList.CheckedItems[x].ToString() + " 가  주문되었습니다.\n"; // 주문한 상품과함께 출력할 문구
                }
                MessageBox.Show(s);
                this.Close();
                th = new Thread(Opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start(); //주문하면 메인으로 가서 주문한걸 확인할 수 있게.
                //주문하고나서 db에 주문한 메뉴 추가 필요.
            }
            else
            {
                s = "상품을 선택하시고 주문해주십시오"; // 상품선택이 없을시 출력할문구
                MessageBox.Show(s);
            }

        }
        private void Opennewform()
        {
            Application.Run(new MainForm());
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
