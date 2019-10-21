using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Kankan_Some_Xinwen
{
    class Weibo_Hots
    {
        private DataSet save;   //某时间段的热搜们
      
        public static int cursor=0;//游标，当前要显示的数据在save的位置

        public Weibo_Hots()
        {
            String connetStr = "";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            MySqlConnection conn = new MySqlConnection(connetStr);



            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改

                string sql = "select * from `weibo` where time >= '2019-10-21 01:00:02'";
                MySqlDataAdapter find = new MySqlDataAdapter(sql, conn);

                save = new DataSet();
                find.Fill(save);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //标题
        public string get_btn_title()
        {
            return save.Tables[0].Rows[cursor][2].ToString();
        }

        //条条大小
        public System.Drawing.Size get_btn_size()
        {
            return new System.Drawing.Size(105 + (int)(66 * Math.Log10(int.Parse(save.Tables[0].Rows[cursor][3].ToString()) / 10000)), 9);
        }

        //热度值
        public string get_lbl_value()
        {
            if (int.Parse(save.Tables[0].Rows[cursor][3].ToString()) >= 1000000)
                return save.Tables[0].Rows[cursor][3].ToString().Substring(0, 3) + "万";
            return save.Tables[0].Rows[cursor][3].ToString();
        }

        //热度值位置
        public System.Drawing.Point get_lbl_location(Smobiler.Core.Controls.Button button, int j)
        {
            return new System.Drawing.Point(button.Location.X + button.Size.Width, 40 + 10 * j);
        }

        //获取热搜时间
        public string get_hot_time()
        {
            return save.Tables[0].Rows[cursor][4].ToString();
        }



        //热搜数量，用以判断截止动态显示
        public int get_hots_num()
        {
            return save.Tables[0].Rows.Count;
        }

    }
}
