using System;
using Smobiler.Core;
namespace To_Kankan_Some_Xinwen
{
    partial class Template_News : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.lbl_news_title = new Smobiler.Core.Controls.Label();
            this.lbl_news_source = new Smobiler.Core.Controls.Label();
            this.lbl_news_time = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lbl_news_title,
            this.lbl_news_source,
            this.lbl_news_time});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            // 
            // lbl_news_title
            // 
            this.lbl_news_title.DataMember = "NEWS_TITLE";
            this.lbl_news_title.DisplayMember = "NEWS_TITLE";
            this.lbl_news_title.Location = new System.Drawing.Point(20, 0);
            this.lbl_news_title.Name = "lbl_news_title";
            this.lbl_news_title.Size = new System.Drawing.Size(260, 35);
            this.lbl_news_title.Text = "韩正出席跨国公司领导人青岛峰会开幕式 宣读习近平主席贺信并致辞";
            // 
            // lbl_news_source
            // 
            this.lbl_news_source.DataMember = "NEWS_SOURCE";
            this.lbl_news_source.DisplayMember = "NEWS_SOURCE";
            this.lbl_news_source.ForeColor = System.Drawing.Color.Gray;
            this.lbl_news_source.Location = new System.Drawing.Point(20, 35);
            this.lbl_news_source.Name = "lbl_news_source";
            this.lbl_news_source.Size = new System.Drawing.Size(120, 15);
            this.lbl_news_source.Text = "新华社";
            // 
            // lbl_news_time
            // 
            this.lbl_news_time.DataMember = "NEWS_TIME";
            this.lbl_news_time.DisplayMember = "NEWS_TIME";
            this.lbl_news_time.ForeColor = System.Drawing.Color.Gray;
            this.lbl_news_time.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lbl_news_time.Location = new System.Drawing.Point(150, 35);
            this.lbl_news_time.Name = "lbl_news_time";
            this.lbl_news_time.Size = new System.Drawing.Size(130, 15);
            this.lbl_news_time.Text = "22:19 2019-10-19";
            // 
            // Template_News
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Load += new System.EventHandler(this.Template_News_Load);
            this.Name = "Template_News";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label lbl_news_title;
        private Smobiler.Core.Controls.Label lbl_news_source;
        private Smobiler.Core.Controls.Label lbl_news_time;
    }
}