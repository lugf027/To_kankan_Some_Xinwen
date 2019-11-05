using System;
using Smobiler.Core;
namespace To_Kankan_Some_Xinwen
{
    partial class Form_Hots : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem4 = new Smobiler.Core.Controls.ToolBarItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.btn_stop = new Smobiler.Core.Controls.Button();
            this.btn_start = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.DodgerBlue;
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Location = new System.Drawing.Point(16, 0);
            this.title1.Name = "title1";
            this.title1.ResourceID = "align-justify";
            this.title1.Size = new System.Drawing.Size(100, 30);
            this.title1.Text = "热搜";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // toolBar1
            // 
            toolBarItem1.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem1.IconID = "ios-paper";
            toolBarItem1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem1.Name = "News";
            toolBarItem1.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem1.SelectIconID = "ios-paper";
            toolBarItem1.Text = "新闻";
            toolBarItem2.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem2.IconID = "bar-chart";
            toolBarItem2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem2.Name = "Hots";
            toolBarItem2.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem2.SelectIconID = "bar-chart";
            toolBarItem2.Text = "热搜";
            toolBarItem3.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem3.IconID = "th-large";
            toolBarItem3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem3.Name = "Types";
            toolBarItem3.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem3.SelectIconID = "th-large";
            toolBarItem3.Text = "分类";
            toolBarItem4.IconColor = System.Drawing.Color.LightSkyBlue;
            toolBarItem4.IconID = "ios-home";
            toolBarItem4.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            toolBarItem4.Name = "Mine";
            toolBarItem4.SelectIconColor = System.Drawing.Color.DodgerBlue;
            toolBarItem4.SelectIconID = "ios-home";
            toolBarItem4.Text = "我";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3,
            toolBarItem4});
            this.toolBar1.ItemWidth = 25;
            this.toolBar1.Location = new System.Drawing.Point(46, 571);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 46);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // btn_stop
            // 
            this.btn_stop.BorderRadius = 30;
            this.btn_stop.Location = new System.Drawing.Point(240, 450);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(50, 50);
            this.btn_stop.Text = "闭嘴";
            this.btn_stop.Press += new System.EventHandler(this.btn_stop_Press);
            // 
            // btn_start
            // 
            this.btn_start.BorderRadius = 30;
            this.btn_start.Location = new System.Drawing.Point(240, 386);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(50, 50);
            this.btn_start.Text = "苏喂";
            this.btn_start.Press += new System.EventHandler(this.btn_start_Press);
            // 
            // Form_Hots
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.toolBar1,
            this.btn_stop,
            this.btn_start});
            this.DrawerName = "Template_Sides_Hot";
            this.Size = new System.Drawing.Size(300, 600);
            this.Load += new System.EventHandler(this.Form_Hots_Load);
            this.Name = "Form_Hots";

        }
        #endregion
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
                       
        public Smobiler.Core.Controls.Button[] buttons = new Smobiler.Core.Controls.Button[51];
        public Smobiler.Core.Controls.Label[] Labels_No = new Smobiler.Core.Controls.Label[51];
        public Smobiler.Core.Controls.Label[] Labels_Value = new Smobiler.Core.Controls.Label[51];
        private Smobiler.Core.Controls.Button btn_stop;
        private Smobiler.Core.Controls.Button btn_start;
    }
}