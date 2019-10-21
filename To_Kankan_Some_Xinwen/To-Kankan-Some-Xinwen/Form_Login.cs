using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using MySql.Data.MySqlClient;
using System.Data;

namespace To_Kankan_Some_Xinwen
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
            InitializeComponent();
            try
            {
                Console.WriteLine("初始化？？？");
                ReadClientData("username", (object s, ClientDataResultHandlerArgs args) =>
                {
                    if (string.IsNullOrEmpty(args.error))
                    {
                        textBox_user.Text = args.Value;
                        Console.WriteLine(args.Value);
                    }
                });
                ReadClientData("password", (object s, ClientDataResultHandlerArgs args) =>
                {
                    if (string.IsNullOrEmpty(args.error))
                    {
                        textBox_pwd.Text = args.Value;
                        Console.WriteLine(args.Value);
                    }
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine("开始清空");
                textBox_user.Text = null;
                textBox_pwd.Text = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_log_Press(object sender, EventArgs e)
        {
            Console.WriteLine("初始化？");
            String connetStr = "server=" + Config.server + ";" +
                                "port=" + Config.port + ";" +
                                "user=" + Config.user + ";" +
                                "password=" + Config.pwd + "; " +
                                "database=" + Config.database + ";";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                string username = textBox_user.Text.Trim();
                string password = textBox_pwd.Text.Trim();
                if (string.IsNullOrEmpty(username))
                    throw new Exception("请输入用户名！");
                if (string.IsNullOrEmpty(password))
                    throw new Exception("请输入密码！");

                if (checkRemeber.Checked == true)
                {
                    LoadClientData("username", textBox_user.Text);
                    LoadClientData("password", textBox_pwd.Text);
                }

                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改

                string sql = "select * from `user_table` where user_name = '" + textBox_user.Text + "'";
                MySqlDataAdapter find = new MySqlDataAdapter(sql, conn);
                DataSet save = new DataSet();

                find.Fill(save);

                if (save.Tables[0].Rows.Count <= 0)
                    throw new Exception("用户不存在，请重新输入！");
                string pwd = save.Tables[0].Rows[0][2].ToString();

                //登录成功，在此跳转
                if (pwd == textBox_pwd.Text)
                {
                    MessageBox.Show("密码正确！");
                    Form_Defult form_Defult = new Form_Defult();
                    this.Show(form_Defult);
                }
                else
                {
                    throw new Exception("密码不正确，请重新输入！");
                }
            }
            catch (Exception ex)
            {
                //RemoveClientData("username", (object s, ClientDataResultHandlerArgs args) =>
                //{
                //    Toast("账户名清空");
                //    Console.WriteLine("11");
                //});
                //RemoveClientData("password", (object s, ClientDataResultHandlerArgs args) =>
                //{
                //    Toast("密码清空");
                //    Console.WriteLine("11");
                //});
                MessageBox.Show(ex.Message);
            }
            finally

            {
                conn.Close();
            }
        }

        private void btn_log_public_Press(object sender, EventArgs e)
        {
            textBox_user.Text = "example";
            textBox_pwd.Text = "123456";
        }
    }
}