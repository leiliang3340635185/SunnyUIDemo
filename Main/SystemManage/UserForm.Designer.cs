
namespace Main.SystemManage
{
    partial class UserForm
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
            this.actionPanel = new Sunny.UI.UIPanel();
            this.btnCancel = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.detailPanel = new Sunny.UI.UIPanel();
            this.txtRoles = new Sunny.UI.UITextBox();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.dpBirthday = new Sunny.UI.UIDatePicker();
            this.cbxGender = new Sunny.UI.UIComboBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtRealName = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.actionPanel.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnCancel);
            this.actionPanel.Controls.Add(this.btnSave);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.actionPanel.Location = new System.Drawing.Point(0, 595);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(800, 55);
            this.actionPanel.TabIndex = 3;
            this.actionPanel.Text = null;
            this.actionPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.actionPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(400, 8);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(314, 8);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Selected = true;
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.txtRoles);
            this.detailPanel.Controls.Add(this.txtEmail);
            this.detailPanel.Controls.Add(this.uiLabel7);
            this.detailPanel.Controls.Add(this.uiLabel6);
            this.detailPanel.Controls.Add(this.dpBirthday);
            this.detailPanel.Controls.Add(this.cbxGender);
            this.detailPanel.Controls.Add(this.txtPassword);
            this.detailPanel.Controls.Add(this.uiLabel5);
            this.detailPanel.Controls.Add(this.uiLabel2);
            this.detailPanel.Controls.Add(this.uiLabel1);
            this.detailPanel.Controls.Add(this.txtRealName);
            this.detailPanel.Controls.Add(this.uiLabel4);
            this.detailPanel.Controls.Add(this.txtAccount);
            this.detailPanel.Controls.Add(this.uiLabel3);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detailPanel.Location = new System.Drawing.Point(0, 35);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(800, 615);
            this.detailPanel.TabIndex = 2;
            this.detailPanel.Text = null;
            this.detailPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.detailPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtRoles
            // 
            this.txtRoles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoles.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRoles.Location = new System.Drawing.Point(302, 371);
            this.txtRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoles.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRoles.Multiline = true;
            this.txtRoles.Name = "txtRoles";
            this.txtRoles.ShowText = false;
            this.txtRoles.Size = new System.Drawing.Size(200, 105);
            this.txtRoles.TabIndex = 13;
            this.txtRoles.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRoles.Watermark = "";
            this.txtRoles.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(302, 309);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(200, 29);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            this.txtEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(237, 371);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(58, 23);
            this.uiLabel7.TabIndex = 13;
            this.uiLabel7.Text = "角色:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(241, 309);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(58, 23);
            this.uiLabel6.TabIndex = 13;
            this.uiLabel6.Text = "邮箱:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dpBirthday
            // 
            this.dpBirthday.FillColor = System.Drawing.Color.White;
            this.dpBirthday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpBirthday.Location = new System.Drawing.Point(302, 250);
            this.dpBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpBirthday.MaxLength = 10;
            this.dpBirthday.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpBirthday.Size = new System.Drawing.Size(200, 29);
            this.dpBirthday.SymbolDropDown = 61555;
            this.dpBirthday.SymbolNormal = 61555;
            this.dpBirthday.TabIndex = 11;
            this.dpBirthday.Text = "2023-06-26";
            this.dpBirthday.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpBirthday.Value = new System.DateTime(2023, 6, 26, 9, 14, 22, 431);
            this.dpBirthday.Watermark = "";
            this.dpBirthday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxGender
            // 
            this.cbxGender.DataSource = null;
            this.cbxGender.FillColor = System.Drawing.Color.White;
            this.cbxGender.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxGender.Location = new System.Drawing.Point(302, 188);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxGender.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxGender.Size = new System.Drawing.Size(200, 29);
            this.cbxGender.TabIndex = 10;
            this.cbxGender.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxGender.Watermark = "";
            this.cbxGender.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(302, 126);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(200, 29);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "";
            this.txtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(237, 256);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(58, 23);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "生日:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(237, 188);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(58, 23);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "性别:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(241, 126);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(58, 23);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "密码:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtRealName
            // 
            this.txtRealName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRealName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRealName.Location = new System.Drawing.Point(302, 68);
            this.txtRealName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRealName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.ShowText = false;
            this.txtRealName.Size = new System.Drawing.Size(200, 29);
            this.txtRealName.TabIndex = 7;
            this.txtRealName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRealName.Watermark = "";
            this.txtRealName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(237, 68);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(58, 23);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "姓名:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccount.Location = new System.Drawing.Point(302, 14);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ShowText = false;
            this.txtAccount.Size = new System.Drawing.Size(200, 29);
            this.txtAccount.TabIndex = 6;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAccount.Watermark = "";
            this.txtAccount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(241, 17);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(54, 23);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "账号:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.detailPanel);
            this.Name = "UserForm";
            this.Text = "用户";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.actionPanel.ResumeLayout(false);
            this.detailPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel actionPanel;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIPanel detailPanel;
        private Sunny.UI.UITextBox txtRealName;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbxGender;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIDatePicker dpBirthday;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txtRoles;
    }
}