
namespace Main
{
    partial class RolePage
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
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtFullName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.btnEdit = new Sunny.UI.UISymbolButton();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.btnQuery = new Sunny.UI.UISymbolButton();
            this.txtEncode = new Sunny.UI.UITextBox();
            this.headPanel = new Sunny.UI.UIPanel();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.dg = new Sunny.UI.UIDataGridView();
            this.update_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyPanel = new Sunny.UI.UIPanel();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(194, 18);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(48, 23);
            this.uiLabel2.TabIndex = 10;
            this.uiLabel2.Text = "名称:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFullName.Location = new System.Drawing.Point(249, 18);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ShowText = false;
            this.txtFullName.Size = new System.Drawing.Size(113, 29);
            this.txtFullName.TabIndex = 9;
            this.txtFullName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFullName.Watermark = "";
            this.txtFullName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtFullName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFullName_KeyUp);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 18);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(48, 23);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "编号:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(638, 17);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.Symbol = 61453;
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(552, 17);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 35);
            this.btnEdit.Symbol = 61508;
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "编辑";
            this.btnEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(466, 17);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.Symbol = 61543;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增";
            this.btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(380, 17);
            this.btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 35);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtEncode
            // 
            this.txtEncode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEncode.Location = new System.Drawing.Point(58, 18);
            this.txtEncode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncode.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.ShowText = false;
            this.txtEncode.Size = new System.Drawing.Size(113, 29);
            this.txtEncode.TabIndex = 5;
            this.txtEncode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEncode.Watermark = "";
            this.txtEncode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtEncode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEncode_KeyUp);
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.uiLabel2);
            this.headPanel.Controls.Add(this.txtFullName);
            this.headPanel.Controls.Add(this.uiLabel1);
            this.headPanel.Controls.Add(this.btnDelete);
            this.headPanel.Controls.Add(this.btnEdit);
            this.headPanel.Controls.Add(this.btnAdd);
            this.headPanel.Controls.Add(this.btnQuery);
            this.headPanel.Controls.Add(this.txtEncode);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(800, 60);
            this.headPanel.TabIndex = 5;
            this.headPanel.Text = null;
            this.headPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.headPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.uiPagination1.TabIndex = 2;
            this.uiPagination1.Text = "uiPagination1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
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
            this.roleid,
            this.encode,
            this.fullname,
            this.description,
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
            this.dg.Size = new System.Drawing.Size(800, 417);
            this.dg.TabIndex = 3;
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
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "角色名称";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // encode
            // 
            this.encode.DataPropertyName = "encode";
            this.encode.HeaderText = "角色编号";
            this.encode.Name = "encode";
            this.encode.ReadOnly = true;
            // 
            // roleid
            // 
            this.roleid.DataPropertyName = "roleid";
            this.roleid.HeaderText = "角色ID";
            this.roleid.Name = "roleid";
            this.roleid.ReadOnly = true;
            this.roleid.Visible = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.dg);
            this.bodyPanel.Controls.Add(this.uiPagination1);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bodyPanel.Location = new System.Drawing.Point(0, 60);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bodyPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(800, 540);
            this.bodyPanel.TabIndex = 8;
            this.bodyPanel.Text = null;
            this.bodyPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bodyPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RolePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.headPanel);
            this.Name = "RolePage";
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.RolePage_Load);
            this.headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtFullName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnEdit;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UITextBox txtEncode;
        private Sunny.UI.UIPanel headPanel;
        private Sunny.UI.UIPagination uiPagination1;
        private Sunny.UI.UIDataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn encode;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_time;
        private Sunny.UI.UIPanel bodyPanel;
    }
}