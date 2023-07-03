
namespace Main
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Size = new System.Drawing.Size(473, 49);
            this.lblTitle.Text = "系统登录";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Text = "";
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(394, 424);
            this.lblSubText.Text = "";
            // 
            // LoginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.MaximumSize = new System.Drawing.Size(750, 400);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.SubText = "";
            this.Text = "LoginForm";
            this.Title = "系统登录";
            this.ResumeLayout(false);

        }

        #endregion
    }
}