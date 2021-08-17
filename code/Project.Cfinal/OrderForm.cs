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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace Project.Cfinal
{
    public partial class OrderForm : Form
    {
        private static int totalcash = 0; //새로 추가 변경
        private static int totalcheck = 0; //새로 추가 변경 
        private static int menucheck = 0;
        private static String[] dbGo;
        private static int[] dbGo2;
        String menupr = ""; //메뉴 출력 이름
        Thread th;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        DBconn d = DBconn.getInstance();
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
            //Orderbot.Click += orderbotclick; //주문하기 클릭 매서드생성
            
        }
 
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) //메인 폼으로 이동
        {
            this.Close();
            th = new Thread(Opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform1()
        {
            Application.Run(new MainForm());  // mainForm 런 매서드 생성
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e) //로그인 폼으로 이동
        {
            this.Close();
            th = new Thread(Opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Opennewform2()
        {
            Application.Run(new LoginForm()); //LoginForm 런매서드 생성
        }
        private void Orderbot_Click(object sender, EventArgs e)
        {
            Ordering();
            if (totalcheck == 0) // 상품 안고를때.
                MessageBox.Show("메인 메뉴를 선택하시고 주문해주십시오");
            else // 하나라도 1개 이상 고를때
            {
                String detail = "";
                String[] dump = { "샷추가 |", "샷추가2 |", "샷추가3 |", "휘핑추가 |", "휘핑추가2 |", "휘핑추가3 |" };
                for (int i = 0; i < OptionList.Items.Count; i++) 
                {
                    if (OptionList.GetItemChecked(i)) 
                    {
                        detail += dump[i];  //+=hh[i]
                    }
                }
                detail += wish.Text;
                MainForm mn = new MainForm();
                for (int i = 0; i < totalcheck; i++)
                {
                    sqluse.insertReservation(dbGo[i], detail, sqluse.getUserName(LoginForm.getUserSerial()), dbGo2[i]);
                    //인써트 dbGo[i]를 주문 메뉴 이름
                    //인써트 dbGo2[i]를 그 메뉴의 주문 개수
                }
                sqluse.plusMoney(LoginForm.getUserSerial(), -totalcash);
                MessageBox.Show(menupr + totalcash.ToString() + "원이 결제되었습니다.");
                this.Close();
                th = new Thread(Opennewform1);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }//버튼 누르면 주문 완료
        }
        private void Ordering() //주문하기를 메소드로 따로 뺌 고장날 예정
        {
            dbGo = new String[orderMenuList.Rows.Count];
            dbGo2 = new int[orderMenuList.Rows.Count];
            int dbcheck = 0;
            for (int i = 0; i < orderMenuList.Rows.Count; i++) //메뉴의 개수만큼.
            {
                if (orderMenuList.Rows[i].Cells[2].Value.ToString() == null)
                    continue;
                String tbx = orderMenuList.Rows[i].Cells[2].Value.ToString();
                String tbt = orderMenuList.Rows[i].Cells[0].Value.ToString();
                if (tbx.Equals(""))
                    totalcash += 0;
                else
                {
                    dbGo[dbcheck] = tbt;
                    dbGo2[dbcheck] = Convert.ToInt32(Regex.Replace(tbx, @"\D", ""));
                    dbcheck++;
                    menupr += tbt + tbx + "잔\n";
                    /*total[i] = Regex.Replace(tbx.Text, @"\D", "");
                    int money = Convert.ToInt32(total[i]);*/
                     int money = Convert.ToInt32(Regex.Replace(tbx, @"\D", ""));
                    /*switch (i)
                    {
                        case 0:
                            money *= 1500;
                            break;
                        case 1:
                        case 2:
                            money *= 2000;
                            break;
                        case 3:
                            money *= 400000;
                            break;

                    }*/
                    menucheck += money;
                    money *= Convert.ToInt32(Regex.Replace(orderMenuList.Rows[i].Cells[1].Value.ToString(), @"\D", ""));
                    
                    totalcash += money;
                    totalcheck++;
                }
            }
            for (int i = 0; i < 6; i++) //옵션 설정
            {
                int[] op = { 500, 1000, 1500, 500, 1000, 1500 };
                //CheckedListBox ch = this.Controls.Find("check" + (i + 1).ToString(), true).FirstOrDefault() as CheckedListBox;
                if (OptionList.GetItemChecked(i))
                    totalcash += op[i];
            }
        }
        private void reset() //가격체크할때 사용. 체크 후 쌓인 값들을 초기화해서 주문버튼을 눌렀을때 2배로 돈이 안나가게 하는 역할 
        {
            menupr = "";
            totalcash = 0;
            totalcheck = 0;
        }
        private MySqlCommand mCommand; // 쿼리문
        private MySqlDataReader mDataReader; // 실행문
        private void OrderForm_Load(object sender, EventArgs e)
        {
            totalcheck = 0;
            totalcash = 0;
            d.connect.Open();
            String query1 = "select menu_name , menu_price from menu where menu_activate = 0";
            MySqlDataAdapter SDA1 = new MySqlDataAdapter(query1, d.connect);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            foreach (DataRow item in dt1.Rows)
            {
                int n = orderMenuList.Rows.Add();
                orderMenuList.Rows[n].Cells[0].Value = item["menu_name"].ToString();
                orderMenuList.Rows[n].Cells[1].Value = item["menu_price"].ToString();
                orderMenuList.Rows[n].Cells[2].Value = "";
            }
            d.connect.Close();
            /*d.connect.Open();
            String sql= "SELECT * FROM menu";
            mCommand = new MySqlCommand(sql, d.connect);
            mDataReader= mCommand.ExecuteReader();*/
            
            /*wish.SelectedIndex = 0;
            nowMoney.ReadOnly = true;
            mCommand = new MySqlCommand(); // 쿼리문 생성
            mCommand.CommandText = "SELECT * FROM menu"; // 쿼리문 작성
            d.connect.Open();
            MySqlDataReader mDataReader = mCommand.ExecuteReader(); // 쿼리문 실행 여기서 오류 발생 ㅠㅠ*/
            /*while (mDataReader.Read()) // 전부 다 읽어 옴
            {
                // 여기서 부터 원하는 데이터를 받아와서 처리
                string tempMenu = mDataReader["menu_name"].ToString();
                string tempPrice = mDataReader["menu_price"].ToString();
                ListViewItem item_temp = new ListViewItem();
                item_temp.Text = tempMenu;
                item_temp.SubItems.Add(tempPrice);
                menu.Items.Add(item_temp);
                
            }
            d.connect.Close();*/
            /*int menutp = 0; // 메뉴 오른쪽거도 추가용
            while (OrderMenuList.Items.Count != menu.Items.Count) //고장날예정
            {                
                ListViewItem item_temp = new ListViewItem();
                String tempMenu = menu.Items[menutp].Text;
                item_temp.Text = tempMenu;
                OrderMenuList.Items.Add(item_temp);
                menutp++;
            }
            for (int i = 1; i <= 8; i++)//고장날예정
            {
                TextBox ord = this.Controls.Find("order" + (i).ToString(), true).FirstOrDefault() as TextBox;
                if (i > OrderMenuList.Items.Count)
                    ord.ReadOnly = true;
            } */
        }
        private static void setdbGo(int i)
        {
            dbGo = new string[i];
            dbGo2 = new int[i];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void OptionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
           
            //MessageBox.Show(orderMenuList.Rows[0].Cells[2].Value.ToString());
            Ordering();
            nowMoney.Text = Convert.ToString(totalcash);
            reset();
        }

        private void menu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}