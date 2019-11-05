using System;
using Smobiler.Core;
namespace To_Kankan_Some_Xinwen
{
    partial class Template_Sides_Hot : Smobiler.Core.Controls.MobileUserControl
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
            this.btn_weibo = new Smobiler.Core.Controls.Button();
            this.btn_zhihu = new Smobiler.Core.Controls.Button();
            this.btn_baidu = new Smobiler.Core.Controls.Button();
            // 
            // btn_weibo
            // 
            this.btn_weibo.BackColor = System.Drawing.Color.Red;
            this.btn_weibo.Location = new System.Drawing.Point(73, 184);
            this.btn_weibo.Name = "btn_weibo";
            this.btn_weibo.Size = new System.Drawing.Size(100, 30);
            this.btn_weibo.Text = "微博";
            // 
            // btn_zhihu
            // 
            this.btn_zhihu.Location = new System.Drawing.Point(73, 239);
            this.btn_zhihu.Name = "btn_zhihu";
            this.btn_zhihu.Size = new System.Drawing.Size(100, 30);
            this.btn_zhihu.Text = "知乎";
            // 
            // btn_baidu
            // 
            this.btn_baidu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_baidu.Location = new System.Drawing.Point(73, 300);
            this.btn_baidu.Name = "btn_baidu";
            this.btn_baidu.Size = new System.Drawing.Size(100, 30);
            this.btn_baidu.Text = "百度";
            // 
            // Template_Sides_Hot
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btn_weibo,
            this.btn_zhihu,
            this.btn_baidu});
            this.Flex = 1;
            this.Size = new System.Drawing.Size(200, 600);
            this.Name = "Template_Sides_Hot";

        }
        #endregion

        private Smobiler.Core.Controls.Button btn_weibo;
        private Smobiler.Core.Controls.Button btn_zhihu;
        private Smobiler.Core.Controls.Button btn_baidu;
    }
}