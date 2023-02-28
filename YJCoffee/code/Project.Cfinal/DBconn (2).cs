using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
        public static DBconn d = DBconn.getInstance();
        public static void dataInsert()
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
        }
        public static int selLogin(String id, String pw)
        {
            int result;
            d.connect.Open();
            String sql = "select user_serial from user where user_id = '" + id + "' and user_pw = '" + pw + "'";
            MySqlCommand command = new MySqlCommand(sql, d.connect);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                table.Read();
                result = Int32.Parse(table["user_serial"].ToString());
                table.Close();
                d.connect.Close();
                if (table == null) return -1;
                if (result >= 0 && result <= 3) return 0;
            }
            catch (Exception ex) //실패라고 출력
            {
                table.Close();
                MessageBox.Show("로그인 실패\n" + ex.ToString());
                return -1;
            }
            
            return 3;
        }
        public static DataSet printMenuOP()
        {
            d.connect.Open();
            MySqlDataAdapter adaptor = new MySqlDataAdapter("select * from menu", d.connect);
            DataSet ds = new DataSet();
            try
            {
                adaptor.Fill(ds);
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
            MySqlDataAdapter adaptor = new MySqlDataAdapter("select * from menu where menu_activate=1", d.connect);
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
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from reservation", d.connect);
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
        public static void insertUser(String id, String pw, String name, DateTime birth, String QnA, String phone, String answer)
        {
            d.connect.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select count(*) from user where user_id='"+id+"' and user_pw='"+pw+"'",d.connect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
                MessageBox.Show("아이디 중복체크를 확인하십시오.");
            else
            {
                MySqlDataAdapter query1 = new MySqlDataAdapter("select max(user_serial) from user", d.connect);
                DataTable table2 = new DataTable();
                query1.Fill(table2);
                int num = int.Parse(table.Rows[0][0].ToString()) + 1;
                query1 = new MySqlDataAdapter("insert into user(user_id, user_pw, user_name, user_birth, user_QnA, user_phonenum, user_Answer) values('" + id + "','" + pw + "','" + name + "','" + birth + "','" + QnA + "','" + phone + "','" + answer + "'",d.connect);
                query1.SelectCommand.ExecuteNonQuery();
            }
            d.connect.Close();
        }
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
