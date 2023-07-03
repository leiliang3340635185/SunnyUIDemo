
namespace Main
{
    partial class MenuPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plAside = new Sunny.UI.UIPanel();
            this.menuTree = new Sunny.UI.UITreeView();
            this.plHeader = new Sunny.UI.UIPanel();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.btnEdit = new Sunny.UI.UISymbolButton();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.plBody = new Sunny.UI.UIPanel();
            this.dg = new Sunny.UI.UIDataGridView();
            this.moduleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plAside.SuspendLayout();
            this.plHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.plBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // plAside
            // 
            this.plAside.Controls.Add(this.menuTree);
            this.plAside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAside.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plAside.Location = new System.Drawing.Point(0, 0);
            this.plAside.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plAside.MinimumSize = new System.Drawing.Size(1, 1);
            this.plAside.Name = "plAside";
            this.plAside.Size = new System.Drawing.Size(208, 649);
            this.plAside.Style = Sunny.UI.UIStyle.Custom;
            this.plAside.TabIndex = 0;
            this.plAside.Text = "plAside";
            this.plAside.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.plAside.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // menuTree
            // 
            this.menuTree.CheckBoxes = true;
            this.menuTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTree.FillColor = System.Drawing.Color.White;
            this.menuTree.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuTree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menuTree.Location = new System.Drawing.Point(0, 0);
            this.menuTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuTree.MinimumSize = new System.Drawing.Size(1, 1);
            this.menuTree.Name = "menuTree";
            this.menuTree.ShowText = false;
            this.menuTree.Size = new System.Drawing.Size(208, 649);
            this.menuTree.Style = Sunny.UI.UIStyle.Custom;
            this.menuTree.TabIndex = 0;
            this.menuTree.Text = "uiTreeView1";
            this.menuTree.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuTree.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.menuTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.menuTree_NodeMouseClick);
            // 
            // plHeader
            // 
            this.plHeader.BackColor = System.Drawing.Color.Silver;
            this.plHeader.Controls.Add(this.btnDelete);
            this.plHeader.Controls.Add(this.btnEdit);
            this.plHeader.Controls.Add(this.btnAdd);
            this.plHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.plHeader.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plHeader.Location = new System.Drawing.Point(0, 0);
            this.plHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.plHeader.Name = "plHeader";
            this.plHeader.Size = new System.Drawing.Size(802, 62);
            this.plHeader.Style = Sunny.UI.UIStyle.Custom;
            this.plHeader.TabIndex = 1;
            this.plHeader.Text = null;
            this.plHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.plHeader.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(197, 12);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.Style = Sunny.UI.UIStyle.Red;
            this.btnDelete.Symbol = 61453;
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnEdit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnEdit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnEdit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(111, 12);
            this.btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnEdit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnEdit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnEdit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnEdit.Size = new System.Drawing.Size(80, 35);
            this.btnEdit.Style = Sunny.UI.UIStyle.Orange;
            this.btnEdit.Symbol = 61508;
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "编辑";
            this.btnEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(25, 12);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.Symbol = 61543;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.plAside);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.plBody);
            this.splitContainerControl1.Panel2.Controls.Add(this.plHeader);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1015, 649);
            this.splitContainerControl1.SplitterPosition = 208;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // plBody
            // 
            this.plBody.Controls.Add(this.dg);
            this.plBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBody.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plBody.Location = new System.Drawing.Point(0, 62);
            this.plBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.plBody.Name = "plBody";
            this.plBody.Size = new System.Drawing.Size(802, 587);
            this.plBody.Style = Sunny.UI.UIStyle.Custom;
            this.plBody.TabIndex = 0;
            this.plBody.Text = null;
            this.plBody.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.plBody.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dg
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dg.ColumnHeadersHeight = 32;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleid,
            this.encode,
            this.fullname,
            this.category,
            this.category_name,
            this.target,
            this.create_time,
            this.update_time});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle8;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dg.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dg.RowTemplate.Height = 23;
            this.dg.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dg.SelectedIndex = -1;
            this.dg.Size = new System.Drawing.Size(802, 587);
            this.dg.Style = Sunny.UI.UIStyle.Custom;
            this.dg.TabIndex = 0;
            this.dg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // moduleid
            // 
            this.moduleid.DataPropertyName = "moduleid";
            this.moduleid.HeaderText = "菜单ID";
            this.moduleid.Name = "moduleid";
            this.moduleid.Visible = false;
            // 
            // encode
            // 
            this.encode.DataPropertyName = "encode";
            this.encode.HeaderText = "编号";
            this.encode.Name = "encode";
            this.encode.Width = 200;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "名称";
            this.fullname.Name = "fullname";
            this.fullname.Width = 150;
            // 
            // category
            // 
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "分类编码";
            this.category.Name = "category";
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "分类名称";
            this.category_name.Name = "category_name";
            this.category_name.Width = 120;
            // 
            // target
            // 
            this.target.DataPropertyName = "target";
            this.target.HeaderText = "目标窗体";
            this.target.Name = "target";
            this.target.Width = 150;
            // 
            // create_time
            // 
            this.create_time.DataPropertyName = "create_time";
            this.create_time.HeaderText = "创建时间";
            this.create_time.Name = "create_time";
            this.create_time.Width = 160;
            // 
            // update_time
            // 
            this.update_time.DataPropertyName = "update_time";
            this.update_time.HeaderText = "更新时间";
            this.update_time.Name = "update_time";
            this.update_time.Width = 160;
            // 
            // MenuPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1015, 649);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MenuPage";
            this.Text = "菜单管理";
            this.Load += new System.EventHandler(this.MenuPage_Load);
            this.plAside.ResumeLayout(false);
            this.plHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.plBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel plAside;
        private Sunny.UI.UIPanel plHeader;
        public Sunny.UI.UITreeView menuTree;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Sunny.UI.UIPanel plBody;
        private Sunny.UI.UIDataGridView dg;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnEdit;
        private Sunny.UI.UISymbolButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn encode;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_time;
    }
}