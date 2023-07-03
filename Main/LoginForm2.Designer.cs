
namespace Main
{
    partial class LoginForm2
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.loginPanel = new Sunny.UI.UIPanel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLine1 = new Sunny.UI.UILine();
            this.edtUser = new Sunny.UI.UITextBox();
            this.edtPassword = new Sunny.UI.UITextBox();
            this.btnLogin = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackgroundImage = global::Main.Properties.Resources.Login12;
            this.uiPanel1.Controls.Add(this.loginPanel);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(750, 375);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.btnCancel);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.edtPassword);
            this.loginPanel.Controls.Add(this.edtUser);
            this.loginPanel.Controls.Add(this.uiLine1);
            this.loginPanel.Controls.Add(this.uiAvatar1);
            this.loginPanel.FillColor = System.Drawing.Color.White;
            this.loginPanel.FillColor2 = System.Drawing.Color.White;
            this.loginPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginPanel.Location = new System.Drawing.Point(419, 51);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.loginPanel.Size = new System.Drawing.Size(207, 242);
            this.loginPanel.Style = Sunny.UI.UIStyle.Custom;
            this.loginPanel.TabIndex = 0;
            this.loginPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Location = new System.Drawing.Point(74, 16);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(60, 60);
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.Location = new System.Drawing.Point(14, 82);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(176, 29);
            this.uiLine1.TabIndex = 1;
            this.uiLine1.Text = "用户登录";
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // edtUser
            // 
            this.edtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edtUser.Location = new System.Drawing.Point(12, 119);
            this.edtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtUser.Name = "edtUser";
            this.edtUser.ShowText = false;
            this.edtUser.Size = new System.Drawing.Size(182, 29);
            this.edtUser.Symbol = 61447;
            this.edtUser.TabIndex = 2;
            this.edtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtUser.Watermark = "";
            this.edtUser.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // edtPassword
            // 
            this.edtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edtPassword.Location = new System.Drawing.Point(14, 158);
            this.edtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.ShowText = false;
            this.edtPassword.Size = new System.Drawing.Size(180, 29);
            this.edtPassword.Symbol = 61475;
            this.edtPassword.TabIndex = 2;
            this.edtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtPassword.Watermark = "";
            this.edtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.edtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtPassword_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(14, 195);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 29);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(104, 195);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Main.Properties.Resources.Login12;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.uiPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 410);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 410);
            this.Name = "LoginForm2";
            this.ShowRadius = false;
            this.ShowRect = false;
            this.Text = "系统登录";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.uiPanel1.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel loginPanel;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UITextBox edtPassword;
        private Sunny.UI.UITextBox edtUser;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UISymbolButton btnLogin;
    }
}