using System;
using Smobiler.Core;
namespace To_Kankan_Some_Xinwen
{
    partial class Template_Hots : Smobiler.Core.Controls.MobileUserControl
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            // 
            // button1
            // 
            this.button1.DataMember = "TITLE";
            this.button1.DisplayMember = "TITLE";
            this.button1.Location = new System.Drawing.Point(0, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 30);
            this.button1.Text = "\t香港往来内地多趟列车临时停运";
            // 
            // label1
            // 
            this.label1.DataMember = "VALUE";
            this.label1.DisplayMember = "VALUE";
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(247, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.Text = "1528503";
            // 
            // Template_Hots
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 40);
            this.Name = "Template_Hots";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label1;
    }
}