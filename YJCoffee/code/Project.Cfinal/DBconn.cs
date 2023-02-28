using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Bcpg;

namespace Project.Cfinal
{
    class DBconn // 싱글톤 객체. DBconn d = DBconn.getInstance(); 명령어 추가하면 DB 연동 끝.
    {
        public MySqlConnection connect = new MySqlConnection("Server=localhost;Port=3306;Database=yjcoffee;Uid=root;Pwd=root");
        
        private static DBconn instance = null;
        public static DBconn getInstance()
        {
            if (instance == null)
            {
                instance = new DBconn();
            }
            return instance;
        }
    }
    class sqluse
    {
        static DBconn d = DBconn.getInstance();
        public static int selLogin(String id, String pw)
        {
            int result;
            d.connect.Open();
            String sql = "select user_serial from user where user_id = '" + id + "' and user_pw = '" + pw + "'";
            MySqlCommand command = new MySqlCommand(sql, d.connect);
            DataTable table = new DataTable();
            //MySqlDataReader table = command.ExecuteReader();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            d.connect.Close();
            try
            {
                //table.Read();
                result = Int32.Parse(table.Rows[0][0].ToString());
                LoginForm.setUserSerial(result);
                //table.Close();
                if (table == null) return -1;
                if (result >= 0 && result <= 3) return 0;
            }
            catch (Exception ex) //실패라고 출력
            {
                //table.Close();
                MessageBox.Show("로그인 실패\n" + ex.ToString());
                return -1;
            }
            return 3;
        }
        public static DataSet printMenuOP()
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select * from menu", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
                d.connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("연결 실패\n"+ex.ToString());
            }
            return ds;
        }
        public static DataSet printMenuOP_using()
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select * from menu where menu_activate=1", d.connect);
            MySqlDataAdapter adaptor = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                adaptor.Fill(ds);
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패\n" + ex.ToString());
            }
            return ds;
        }
        public static DataSet printReserve()
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=0;", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패\n" + ex.ToString());
            }
            return ds;
        }
        public static DataSet printReserve2()
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select reservation_time, menu_name, reservation_detail, user_id from reservation where reservation_OK=1 and reservation_ready=0;", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패\n" + ex.ToString());
            }
            return ds;
        }
        public static DataSet printReserveAll()
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select * from reservation;", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패\n" + ex.ToString());
            }
            return ds;
        }
        public static int insertUser(String id, String pw, String name, String birth, String phone)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select count(*) from user where user_id='" + id + "';", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                if (table.Rows[0][0].ToString() != "0")
                    MessageBox.Show("아이디 중복체크를 확인하십시오.");
                else
                {
                    MySqlCommand command1 = new MySqlCommand("insert into user(user_id, user_pw, user_name, user_birth, user_phonenum) values('" + id + "','" + pw + "','" + name + "','" + birth + "','" + phone + "');", d.connect);
                    if (command1.ExecuteNonQuery() == 1)
                        MessageBox.Show("성공적으로 생성되었습니다. 생성한 아이디로 로그인 해 주세요.");
                    d.connect.Close();


                    return 1;
                }
                d.connect.Close();
                return 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                d.connect.Close();
                return 0;
            }
            
        }
        public static int checkID(String id)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select count(*) from user where user_id='" + id + "';", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                if (Int32.Parse(table.Rows[0][0].ToString())!=0)
                {
                    MessageBox.Show("중복된 아이디입니다.", "중복");
                    d.connect.Close();
                }
                else
                {
                    MessageBox.Show("사용 가능한 아이디입니다.", "가능");
                    d.connect.Close();
                    return 1;
                }
                d.connect.Close();
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                return 0;
            }
        }
        public static int findID(String name, String phonenum)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select count(*) from user where user_name='" + name + "'and user_phonenum='" + phonenum + "';", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            try
            {
                if (table.Rows[0][0].ToString() == "1")
                {
                    command = new MySqlCommand("select user_id from user where user_name='" + name + "' and user_phonenum='" + phonenum + "';", d.connect);
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(command);
                    DataTable table2 = new DataTable();
                    adapter1.Fill(table2);
                    MessageBox.Show("아이디는 " + table2.Rows[0][0].ToString()+ "입니다.");
                    d.connect.Close();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("찾기에 실패하였습니다\n" + ex.ToString());
                d.connect.Close();
                return 0;
            }
        }
        public static int findPW(String id, String name, String phonenum)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select count(*) from user where user_id='"+id+"' and user_name='" + name + "'and user_phonenum='" + phonenum + "';", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                if (table.Rows[0][0].ToString() == "1")
                {
                    command = new MySqlCommand("select user_pw from user where user_name='" + name + "'and user_phonenum='" + phonenum + "';", d.connect);
                    adapter = new MySqlDataAdapter(command);
                    DataTable table2 = new DataTable();
                    adapter.Fill(table2);
                    MessageBox.Show("비밀번호는 " + table2.Rows[0][0].ToString() + "입니다.");
                    d.connect.Close();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("찾기에 실패하였습니다\n" + ex.ToString());
                return 0;
            }
        }
        public static int getWaiting()
        {
            MySqlCommand command = new MySqlCommand("select count(*) from reservation where reservation_OK=1 and reservation_ready=0;", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Int32.Parse(table.Rows[0][0].ToString());
        }
        public static int getOrdered()
        {
            MySqlCommand command = new MySqlCommand("select count(*) from reservation where reservation_OK=0;", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Int32.Parse(table.Rows[0][0].ToString());
        }
        public static String getUserName(int serial)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select user_id from user where user_serial=" + serial+";", d.connect) ;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            d.connect.Close();
            DataTable table = new DataTable();
            adapter.Fill(table);
            String result;
            try
            {
                result = table.Rows[0][0].ToString();
                return result;
            }
            catch(Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
            }
            return null;
        }
        public static int getUserMoney(int serial)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select user_money from user where user_serial=" + serial + ";", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            d.connect.Close();
            DataTable table = new DataTable();
            adapter.Fill(table);
            int result;
            try
            {
                result = Int32.Parse(table.Rows[0][0].ToString());
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
            }
            return -1;
        }
        public static DataSet printReserveUser(int serial)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select reservation_time, menu_name, reservation_detail, reservation_ready, reservation_OK from reservation where user_serial="+serial+";", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("연결 실패\n" + ex.ToString());
            }
            return ds;
        }
        public static void updateUser(String pw, String name, String phone, int serial)
        {
            d.connect.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("update user set user_pw='" + pw + "', user_name='" + name + "', user_phonenum='" + phone + "' where user_serial=" + serial + ";", d.connect);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("성공적으로 저장되었습니다.");
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                d.connect.Close();
            }
        }
        public static void updatePW(String pw, int serial)
        {
            d.connect.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("update user set user_pw='" + pw + "' where user_serial=" + serial + ";", d.connect);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("성공적으로 저장되었습니다.");
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                d.connect.Close();
            }
        }
        public static String getID(int serial)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select user_id from user where user_serial=" + serial + ";", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            d.connect.Close();
            DataTable table = new DataTable();
            String a;
            try
            {
                adapter.Fill(table);
                a = table.Rows[0][0].ToString();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                return null;
            }
        }
        public static String getBirth(int serial)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select user_birth from user where user_serial=" + serial + ";", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            d.connect.Close();
            DataTable table = new DataTable();
            String a;
            try
            {
                adapter.Fill(table);
                a = table.Rows[0][0].ToString();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                return null;
            }
        }
        public static String getName(int serial)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select user_name from user where user_serial=" + serial + ";", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            d.connect.Close();
            DataTable table = new DataTable();
            String a;
            try
            {
                adapter.Fill(table);
                a = table.Rows[0][0].ToString();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                return null;
            }
        }
        public static String getPhone(int serial)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("select user_phonenum from user where user_serial=" + serial + ";", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            d.connect.Close();
            DataTable table = new DataTable();
            String a;
            try
            {
                adapter.Fill(table);
                a = table.Rows[0][0].ToString();
                return a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
                return null;
            }
        }
        public static void asdf(DataGridView view)
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM menu", d.connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                foreach (DataRow item in table.Rows)
                {
                    int n = view.Rows.Add();
                    view.Rows[n].Cells[0].Value = "false";
                    view.Rows[n].Cells[1].Value = item["menu_id"].ToString();
                    view.Rows[n].Cells[2].Value = item["menu_Hot"].ToString();
                    view.Rows[n].Cells[3].Value = item["menu_ICE"].ToString();
                    view.Rows[n].Cells[4].Value = item["menu_Stock"].ToString();
                }
                d.connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
            }
        }
        public static void plusMoney(int serial, int money)
        {
            d.connect.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("update user set user_money=user_money+" + money + " where user_serial=" + serial + ";", d.connect);
                d.connect.Close();
            }
            catch (Exception ex)
            {
                d.connect.Close();
                MessageBox.Show("실패\n" + ex.ToString());
            }
        }
        public static void insertReservation(String menu, String detail, String id, int count)
        {
            d.connect.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("insert into reservation(reservation_time, menu_name, reservation_detail, user_id, reservation_count) values('" + DateTime.Now.ToString() + "', '" + menu + "', '" + detail + "', '" + id + "', " + count + ");", d.connect);
                d.connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("실패\n" + ex.ToString());
            }
        }
        /*복붙 ㄱ
         *         private void button4_Click(object sender, EventArgs e) 데이터 확인 foreach문을 써서 데이터 나열시키는거임
        {
            con.Open();
            String query = "SELECT * FROM CafeMenu";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "false";
                dataGridView1.Rows[n].Cells[1].Value = item["Menu_id"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Menu_Hot"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Menu_ICE"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Menu_Stock"].ToString();
            }
            //dataGridView1.DataSource = dt;
            con.Close();
        }
                 private void button6_Click(object sender, EventArgs e) //버튼 6 readonly 푸는거
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString())) 
                {
                    item.Cells[5].ReadOnly = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e) //readonly데이터 메세지창으로 띄우는거
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                    MessageBox.Show(item.Cells[5].Value.ToString());
            }
        }
         */




        /*public static void dataInsert()
        {
            d.connect.Open();
            MySqlCommand command = new MySqlCommand("insert into menu values(00000002, '카페라떼', 2000, 0, 1)", d.connect);
            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("인서트 성공");
                }
                else
                {
                    Console.WriteLine("인서트 성공");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }*/
    }
    /*public static void makeMember()
    {

    }
    public static void makeMenu()
    {

    }
    public static void insertOrder()
    {

    }
    */
    //SQL 구문 사용할 거 필요한 거 있으면 적어주셈. 구현 하겠음.

    /*class sqluse
   {
       public static void selMenu()
       {
           DBconn d = DBconn.getInstance();
           try
           {
               d.connect.Open();
               String sql = "select menu_name, menu_price, menu_done from menu;";
               MySqlCommand command = new MySqlCommand(sql, d.connect);
               MySqlDataReader table = command.ExecuteReader();
               while (table.Read())
               {
                   //메뉴 만들어지는 거 구성 보고 수정 할 예정
                   Console.WriteLine("{0} {1}", table["idx"], table["header"], table["body"]);
               }
               table.Close();
               catch (Exception ex)
           {
               //실패라고 출력
               Console.WriteLine("실패");
               Console.WriteLine(ex.ToString());
               //실패 오류코드 출력 ex.toString();
           }
           }
       }
   }*/


    /*class sqluse
    {
        private static void InsertUpdate()
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=zzz;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Tab1 VALUES (2, 'Tom')", conn);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Tab1 SET Name='Tim' WHERE Id=2";
                cmd.ExecuteNonQuery();
            }
        }
        private static void SelectUsingReader()
        {
            string connStr = "Server=localhost;Database=test;Uid=root;Pwd=zzz;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Tab1 WHERE Id>=2";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0}: {1}", rdr["Id"], rdr["Name"]);
                }
                rdr.Close();
            }
        }

        private static void SelectUsingAdapter()
        {
            DataSet ds = new DataSet();
            string connStr = "Server=localhost;Database=test;Uid=root;Pwd=zzz;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //MySqlDataAdapter 클래스를 이용하여
                //비연결 모드로 데이타 가져오기
                string sql = "SELECT * FROM Tab1 WHERE Id>=2";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Tab1");
            }

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Console.WriteLine(r["Name"]);
            }
        }
         1. DB가 디폴트로 UTF8 Collation을 갖는지 체크
        SELECT schema_name, default_character_set_name
        FROM information_schema.SCHEMATA
         2. MySQL Connector/Net 연결문자열 (Charset)
        string cn = "Server=localhost;Database=db;Uid=u;Pwd=p;Charset=utf8";
    }*/
}