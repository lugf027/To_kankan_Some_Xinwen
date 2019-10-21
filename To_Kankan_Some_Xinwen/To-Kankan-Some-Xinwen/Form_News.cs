using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

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
            DataTable table = new DataTable();
            table.Columns.Add("NEWS_TITLE", typeof(System.String));
            table.Columns.Add("NEWS_SOURCE", typeof(System.String));
            table.Columns.Add("NEWS_TIME", typeof(System.String));

            //测试数据
            table.Rows.Add("俄炮兵部队改革：先从装备入手", "人民网", "2019-10-18");
            table.Rows.Add("加州大学洛杉矶分校研究表明类地行星在宇宙中可能很常见", "博客园", "2019-10-18 10:14");
            table.Rows.Add("美国左右摇摆，土耳其态度强硬", "人民网", "2019-10-18");
            table.Rows.Add("英特尔将发布新一代低功耗架构Tremont，GPU性能或大幅提升", "博客园", "2019-10-19 16:02");
            table.Rows.Add("微软将不再把.NET Framework API 移植到.NET Core 3.0", "博客园", "2019-10-18 13:29");
            table.Rows.Add("美国左右摇摆，土耳其态度强硬", "人民网", "2019-10-18");
            table.Rows.Add("加州大学洛杉矶分校研究表明类地行星在宇宙中可能很常见", "博客园", "2019-10-18 10:14");
            table.Rows.Add("美国左右摇摆，土耳其态度强硬", "人民网", "2019-10-18");
            table.Rows.Add("英特尔将发布新一代低功耗架构Tremont，GPU性能或大幅提升", "博客园", "2019-10-19 16:02");
            table.Rows.Add("微软将不再把.NET Framework API 移植到.NET Core 3.0", "博客园", "2019-10-18 13:29");
            table.Rows.Add("东部战区军事检察院走进革命老区开设主题教育课堂", "人民网", "2019-10-18");
            table.Rows.Add("国际军体主席：武汉军运会将开启军事体育的新时代", "人民网", "2019-10-17");
            table.Rows.Add("加州大学洛杉矶分校研究表明类地行星在宇宙中可能很常见", "博客园", "2019-10-18 10:14");
            table.Rows.Add("英特尔将发布新一代低功耗架构Tremont，GPU性能或大幅提升", "博客园", "2019-10-19 16:02");
            table.Rows.Add("微软将不再把.NET Framework API 移植到.NET Core 3.0", "博客园", "2019-10-18 13:29");
            table.Rows.Add("俄炮兵部队改革：先从装备入手", "人民网", "2019-10-18");
            table.Rows.Add("美国左右摇摆，土耳其态度强硬", "人民网", "2019-10-18");
            table.Rows.Add("东部战区军事检察院走进革命老区开设主题教育课堂", "人民网", "2019-10-18");

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