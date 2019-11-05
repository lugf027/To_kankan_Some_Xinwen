using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Threading;

namespace To_Kankan_Some_Xinwen
{
    partial class Form_Hots : Smobiler.Core.Controls.MobileForm
    {

        private Weibo_Hots weibo_hots;

        public Form_Hots() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "Hots": Form_Hots form_hots = new Form_Hots(); this.Show(form_hots); break;
                case "News": Form_Defult form_news = new Form_Defult(); this.Show(form_news); break;
                case "Types": Form_Types form_types = new Form_Types(); this.Show(form_types); break;
                case "Mine": Form_Mine form_mine = new Form_Mine(); this.Show(form_mine); break;
                default:
                    break;
            };
        }

        private void Form_Hots_Load(object sender, EventArgs e)
        {
            //
            weibo_hots = new Weibo_Hots();
            String connetStr = "server=" + Config.server + ";" +
                                "port=" + Config.port + ";" +
                                "user=" + Config.user + ";" +
                                "password=" + Config.pwd + "; " +
                                "database=" + Config.database + ";";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            MySqlConnection conn = new MySqlConnection(connetStr);

            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改

                string sql = "select * from `weibo` where time = '2019-10-21 00:59:01'";
                MySqlDataAdapter find = new MySqlDataAdapter(sql, conn);
                DataSet save = new DataSet();

                find.Fill(save);

                if (save.Tables[0].Rows.Count == 51) { 
                    for (int i = 0; i < 51; i++)
                    {
                        //设置序号Label
                        Labels_No[i] = new Label
                        {
                            Location = new System.Drawing.Point(2, 40 + 10 * i),
                            Name = "Lable_No" + i.ToString(),
                            Size = new System.Drawing.Size(16, 9),
                            Text = save.Tables[0].Rows[i][1].ToString(),
                            ForeColor = System.Drawing.Color.Gray,
                            FontSize = 10
                        };
                        //序号能整除5时黑色（其他灰色）
                        if (i % 5 == 0)
                            Labels_No[i].ForeColor = System.Drawing.Color.Black;

                        buttons[i] = new Button
                        {
                            Location = new System.Drawing.Point(20, 40 + 10 * i),
                            Name = "button" + i.ToString(),
                            Size = new System.Drawing.Size(105 + (int)(66 * Math.Log10(int.Parse(save.Tables[0].Rows[i][3].ToString()) / 10000)), 9),
                            Text = save.Tables[0].Rows[i][2].ToString(),
                            BackColor = Colors.get_color(),
                            HorizontalAlignment = HorizontalAlignment.Right,
                            FontSize = 10
                        };

                        Labels_Value[i] = new Label
                        {
                            Location = new System.Drawing.Point(buttons[i].Location.X+buttons[i].Size.Width
                            , 40 + 10 * i),
                            Name = "Lable_No" + i.ToString(),
                            Size = new System.Drawing.Size(54, 9),
                            Text = save.Tables[0].Rows[i][3].ToString(),
                            ForeColor = System.Drawing.Color.Black,
                            FontSize = 10
                        };
                        if (int.Parse(save.Tables[0].Rows[i][3].ToString()) >= 1000000)
                            Labels_Value[i].Text = save.Tables[0].Rows[i][3].ToString().Substring(0, 3) + "万";
                        if (i == 50)
                        {
                            Labels_No[i].Text = "顶";
                            Labels_No[i].Location = new System.Drawing.Point(2, 30);
                            Labels_Value[i].Text = "";
                            buttons[i].Size = new System.Drawing.Size(280, 9);
                            buttons[i].Location = new System.Drawing.Point(20, 30);
                        }
                        this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] { Labels_No[i], buttons[i], Labels_Value[i] });
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            OpenDrawer();
        }

        private void btn_start_Press(object sender, EventArgs e)
        {
            this.Client.Timer.Start(2, (obj, args) => { 
                Toast("当时时间" + weibo_hots.get_hot_time());
                for (int i = 0; i < 51; i++)
                {
                    //条条的更新
                    buttons[i].BackColor = Colors.get_color();
                    buttons[i].Text = weibo_hots.get_btn_title();
                    buttons[i].Size = weibo_hots.get_btn_size();
                    //热搜值的更新
                    Labels_Value[i].Text = weibo_hots.get_lbl_value();
                    Labels_Value[i].Location = weibo_hots.get_lbl_location(buttons[i], i);
                    Labels_Value[i].ForeColor = weibo_hots.get_lbl_color();
                    //置顶热搜特殊处理
                    if (i == 50)
                    {
                        Labels_No[i].Text = "顶";
                        Labels_No[i].Location = new System.Drawing.Point(2, 30);
                        Labels_Value[i].Text = "";
                        buttons[i].Size = new System.Drawing.Size(280, 9);
                        buttons[i].Location = new System.Drawing.Point(20, 30);
                    }

                    Weibo_Hots.cursor += 1; //前进一位表格数据
                }

                if (Weibo_Hots.cursor == weibo_hots.get_hots_num())
                    Client.Timer.Stop();

            });//Start方法后面第1个参数为触发间隔的秒，第二个参数是Tick回调
        }

        private void btn_stop_Press(object sender, EventArgs e)
        {
            this.Client.Timer.Stop();
        }
    }
}