
namespace Main
{
    partial class UserPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg = new Sunny.UI.UIDataGridView();
            this.update_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.bodyPanel = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.headPanel = new Sunny.UI.UIPanel();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.txtRealName = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.ColumnHeadersHeight = 32;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.account,
            this.realname,
            this.gender,
            this.birthday,
            this.email,
            this.roleid,
            this.create_by,
            this.create_time,
            this.update_by,
            this.update_time});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg.Dock = System.Windows.Forms.DockStyle.Top;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dg.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg.RowTemplate.Height = 23;
            this.dg.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dg.SelectedIndex = -1;
            this.dg.Size = new System.Drawing.Size(800, 439);
            this.dg.Style = Sunny.UI.UIStyle.Custom;
            this.dg.TabIndex = 0;
            this.dg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // update_time
            // 
            this.update_time.DataPropertyName = "update_time";
            this.update_time.HeaderText = "更新时间";
            this.update_time.Name = "update_time";
            this.update_time.ReadOnly = true;
            this.update_time.Width = 160;
            // 
            // update_by
            // 
            this.update_by.DataPropertyName = "update_by";
            this.update_by.HeaderText = "更新人";
            this.update_by.Name = "update_by";
            this.update_by.ReadOnly = true;
            // 
            // create_time
            // 
            this.create_time.DataPropertyName = "create_time";
            this.create_time.HeaderText = "创建时间";
            this.create_time.Name = "create_time";
            this.create_time.ReadOnly = true;
            this.create_time.Width = 160;
            // 
            // create_by
            // 
            this.create_by.DataPropertyName = "create_by";
            this.create_by.HeaderText = "创建人";
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            // 
            // roleid
            // 
            this.roleid.DataPropertyName = "roleid";
            this.roleid.HeaderText = "角色";
            this.roleid.Name = "roleid";
            this.roleid.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "邮箱";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "生日";
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 160;
            // 
            // realname
            // 
            this.realname.DataPropertyName = "realname";
            this.realname.HeaderText = "姓名";
            this.realname.Name = "realname";
            this.realname.ReadOnly = true;
            // 
            // account
            // 
            this.account.DataPropertyName = "account";
            this.account.HeaderText = "账号";
            this.account.Name = "account";
            this.account.ReadOnly = true;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "用户ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Visible = false;
            // 
            // uiPagination1
            // 
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPagination1.Location = new System.Drawing.Point(19, 447);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.PageSize = 5;
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.ShowText = false;
            this.uiPagination1.Size = new System.Drawing.Size(697, 37);
            this.uiPagination1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPagination1.TabIndex = 2;
            this.uiPagination1.Text = "uiPagination1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.uiPagination1);
            this.bodyPanel.Controls.Add(this.dg);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bodyPanel.Location = new System.Drawing.Point(0, 60);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bodyPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(800, 540);
            this.bodyPanel.Style = Sunny.UI.UIStyle.Custom;
            this.bodyPanel.TabIndex = 4;
            this.bodyPanel.Text = null;
            this.bodyPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bodyPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 19);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(48, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "账号:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(194, 19);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(48, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 10;
            this.uiLabel2.Text = "姓名:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.uiLabel2);
            this.headPanel.Controls.Add(this.txtRealName);
            this.headPanel.Controls.Add(this.uiLabel1);
            this.headPanel.Controls.Add(this.txtAccount);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(800, 60);
            this.headPanel.Style = Sunny.UI.UIStyle.Custom;
            this.headPanel.TabIndex = 0;
            this.headPanel.Text = null;
            this.headPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.headPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAccount.Location = new System.Drawing.Point(58, 18);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ShowText = false;
            this.txtAccount.Size = new System.Drawing.Size(113, 29);
            this.txtAccount.Style = Sunny.UI.UIStyle.Custom;
            this.txtAccount.TabIndex = 5;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAccount.Watermark = "";
            this.txtAccount.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAccount_KeyUp);
            // 
            // txtRealName
            // 
            this.txtRealName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRealName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRealName.Location = new System.Drawing.Point(249, 18);
            this.txtRealName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRealName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.ShowText = false;
            this.txtRealName.Size = new System.Drawing.Size(113, 29);
            this.txtRealName.Style = Sunny.UI.UIStyle.Custom;
            this.txtRealName.TabIndex = 9;
            this.txtRealName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRealName.Watermark = "";
            this.txtRealName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtRealName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRealName_KeyUp);
            // 
            // UserPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.headPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserPage";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "用户管理";
            this.TitleFillColor = System.Drawing.Color.LightSkyBlue;
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn realname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_time;
        private Sunny.UI.UIPagination uiPagination1;
        private Sunny.UI.UIPanel bodyPanel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIPanel headPanel;
        private Sunny.UI.UITextBox txtRealName;
        private Sunny.UI.UITextBox txtAccount;
    }
}