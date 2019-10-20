using System;
using Smobiler.Core;
namespace To_Kankan_Some_Xinwen
{
    partial class Form_Defult : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem9 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem10 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem11 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem12 = new Smobiler.Core.Controls.ToolBarItem();
            this.title_defult = new Smobiler.Core.Controls.Title();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            // 
            // title_defult
            // 
            this.title_defult.BackColor = System.Drawing.Color.DodgerBlue;
            this.title_defult.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title_defult.ImageWidth = 40;
            this.title_defult.Location = new System.Drawing.Point(108, 58);
            this.title_defult.Name = "title_defult";
            this.title_defult.ResourceID = "align-justify";
            this.title_defult.Size = new System.Drawing.Size(100, 30);
            this.title_defult.Text = "新闻界面";
            this.title_defult.ImagePress += new System.EventHandler(this.title_defult_ImagePress);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 30);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(300, 482);
            this.listView1.TemplateControlName = "Template_News";
            // 
            // toolBar1
            // 
            toolBarItem9.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem9.IconID = "ios-paper";
            toolBarItem9.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem9.Name = "News";
            toolBarItem9.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem9.SelectIconID = "ios-paper";
            toolBarItem9.Text = "新闻";
            toolBarItem10.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem10.IconID = "bar-chart";
            toolBarItem10.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem10.Name = "Hots";
            toolBarItem10.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem10.SelectIconID = "bar-chart";
            toolBarItem10.Text = "热搜";
            toolBarItem11.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem11.IconID = "th-large";
            toolBarItem11.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem11.Name = "Types";
            toolBarItem11.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem11.SelectIconID = "th-large";
            toolBarItem11.Text = "分类";
            toolBarItem12.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem12.IconID = "ios-home";
            toolBarItem12.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem12.Name = "Mine";
            toolBarItem12.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem12.SelectIconID = "ios-home";
            toolBarItem12.Text = "我";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem9,
            toolBarItem10,
            toolBarItem11,
            toolBarItem12});
            this.toolBar1.ItemWidth = 25;
            this.toolBar1.Location = new System.Drawing.Point(46, 571);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 73);
            // 
            // Form_Defult
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title_defult,
            this.listView1,
            this.toolBar1});
            this.DrawerName = "Template_Sides";
            this.DrawerWidth = 200;
            this.Size = new System.Drawing.Size(300, 600);
            this.Load += new System.EventHandler(this.Form_Defult_Load);
            this.Name = "Form_Defult";

        }
        #endregion

        private Smobiler.Core.Controls.Title title_defult;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
    }
}