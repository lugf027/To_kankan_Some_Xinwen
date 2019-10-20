using Smobiler.Core;

namespace To_Kankan_Some_Xinwen
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lbl_whu = new Smobiler.Core.Controls.Label();
            this.lbl_lgf = new Smobiler.Core.Controls.Label();
            this.fontIcon_user = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.textBox_user = new Smobiler.Core.Controls.TextBox();
            this.textBox_pwd = new Smobiler.Core.Controls.TextBox();
            this.checkRemeber = new Smobiler.Core.Controls.CheckBox();
            this.label_tip = new Smobiler.Core.Controls.Label();
            this.btn_log = new Smobiler.Core.Controls.Button();
            this.btn_log_public = new Smobiler.Core.Controls.Button();
            // 
            // lbl_whu
            // 
            this.lbl_whu.Bold = true;
            this.lbl_whu.FontSize = 50F;
            this.lbl_whu.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lbl_whu.Location = new System.Drawing.Point(50, 50);
            this.lbl_whu.Name = "lbl_whu";
            this.lbl_whu.Size = new System.Drawing.Size(200, 50);
            this.lbl_whu.Text = "W H U";
            this.lbl_whu.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // lbl_lgf
            // 
            this.lbl_lgf.FontSize = 20F;
            this.lbl_lgf.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lbl_lgf.Location = new System.Drawing.Point(50, 100);
            this.lbl_lgf.Name = "lbl_lgf";
            this.lbl_lgf.Size = new System.Drawing.Size(200, 20);
            this.lbl_lgf.Text = "L U G F 0 2 7";
            // 
            // fontIcon_user
            // 
            this.fontIcon_user.ForeColor = System.Drawing.Color.DodgerBlue;
            this.fontIcon_user.Location = new System.Drawing.Point(50, 219);
            this.fontIcon_user.Name = "fontIcon_user";
            this.fontIcon_user.ResourceID = "user";
            this.fontIcon_user.Size = new System.Drawing.Size(40, 40);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.fontIcon1.Location = new System.Drawing.Point(50, 269);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "lock";
            this.fontIcon1.Size = new System.Drawing.Size(40, 40);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(100, 224);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(150, 30);
            this.textBox_user.WaterMarkText = "账号";
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(100, 274);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.SecurityMode = true;
            this.textBox_pwd.Size = new System.Drawing.Size(150, 30);
            this.textBox_pwd.WaterMarkText = "密码";
            // 
            // checkRemeber
            // 
            this.checkRemeber.Location = new System.Drawing.Point(70, 319);
            this.checkRemeber.Name = "checkRemeber";
            this.checkRemeber.Size = new System.Drawing.Size(20, 20);
            this.checkRemeber.TintColor = System.Drawing.Color.Gray;
            // 
            // label_tip
            // 
            this.label_tip.ForeColor = System.Drawing.Color.Gray;
            this.label_tip.Location = new System.Drawing.Point(100, 319);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(150, 20);
            this.label_tip.Text = "记住用户名与密码";
            // 
            // btn_log
            // 
            this.btn_log.BorderRadius = 20;
            this.btn_log.FontSize = 30F;
            this.btn_log.Location = new System.Drawing.Point(70, 369);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(160, 40);
            this.btn_log.Text = "登 录";
            this.btn_log.Press += new System.EventHandler(this.btn_log_Press);
            // 
            // btn_log_public
            // 
            this.btn_log_public.BorderRadius = 20;
            this.btn_log_public.FontSize = 30F;
            this.btn_log_public.Location = new System.Drawing.Point(70, 427);
            this.btn_log_public.Name = "btn_log_public";
            this.btn_log_public.Size = new System.Drawing.Size(160, 40);
            this.btn_log_public.Text = "一键登录";
            this.btn_log_public.Press += new System.EventHandler(this.btn_log_public_Press);
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lbl_whu,
            this.lbl_lgf,
            this.fontIcon_user,
            this.fontIcon1,
            this.textBox_user,
            this.textBox_pwd,
            this.checkRemeber,
            this.label_tip,
            this.btn_log,
            this.btn_log_public});
            this.Size = new System.Drawing.Size(300, 600);
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Label lbl_whu;
        private Smobiler.Core.Controls.Label lbl_lgf;
        private Smobiler.Core.Controls.FontIcon fontIcon_user;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.TextBox textBox_user;
        private Smobiler.Core.Controls.TextBox textBox_pwd;
        private Smobiler.Core.Controls.CheckBox checkRemeber;
        private Smobiler.Core.Controls.Label label_tip;
        private Smobiler.Core.Controls.Button btn_log;
        private Smobiler.Core.Controls.Button btn_log_public;
    }
}