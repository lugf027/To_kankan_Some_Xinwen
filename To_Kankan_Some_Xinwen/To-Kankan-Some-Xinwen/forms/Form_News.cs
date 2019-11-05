using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using To_Kankan_Some_Xinwen.binds;
using To_Kankan_Some_Xinwen.news;

namespace To_Kankan_Some_Xinwen
{
    partial class Form_Defult : Smobiler.Core.Controls.MobileForm
    {
        public Form_Defult() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void Form_Defult_Load(object sender, EventArgs e)
        {
            //首页新闻
            RenminwangNews[] renminwangNews = News.GetRenminwangNews(Config.defaultNewsType, Config.defaultNewsPage);

            DataTable table = new DataTable();
            table.Columns.Add("NEWS_TITLE", typeof(System.String));
            table.Columns.Add("NEWS_SOURCE", typeof(System.String));
            table.Columns.Add("NEWS_TIME", typeof(System.String));

            for(int i=0; i<renminwangNews.Length; i++)
            {
                table.Rows.Add(renminwangNews[i].title, renminwangNews[i].source, renminwangNews[i].time);

            }

            listView1.Rows.Clear(); //清除数据
            if(table.Rows.Count > 0)    //绑定数据源
            {
                listView1.DataSource = table;
                listView1.DataBind();
            }
        }

        private void title_defult_ImagePress(object sender, EventArgs e)
        {
            OpenDrawer();
        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "Hots": Form_Hots form_hots = new Form_Hots();this.Show(form_hots); break;
                case "News":Form_Defult form_news = new Form_Defult(); this.Show(form_news); break;
                case "Types": Form_Types form_types = new Form_Types(); this.Show(form_types); break;
                case "Mine": Form_Mine form_mine = new Form_Mine(); this.Show(form_mine); break;
                default:
                    break;
            };

        }
    }
}