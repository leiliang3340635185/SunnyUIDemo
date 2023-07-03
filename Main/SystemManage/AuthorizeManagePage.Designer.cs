
namespace Main
{
    partial class AuthorizeManagePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnQuery = new Sunny.UI.UISymbolButton();
            this.txtKeyword = new Sunny.UI.UITextBox();
            this.cbxAuthorizeType = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.dg = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtKeyword);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbxAuthorizeType);
            this.splitContainerControl1.Panel1.Controls.Add(this.uiLabel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.uiPagination1);
            this.splitContainerControl1.Panel2.Controls.Add(this.dg);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(800, 600);
            this.splitContainerControl1.SplitterPosition = 66;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(474, 17);
            this.btnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 30);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeyword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyword.Location = new System.Drawing.Point(317, 18);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeyword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.ShowText = false;
            this.txtKeyword.Size = new System.Drawing.Size(150, 29);
            this.txtKeyword.TabIndex = 2;
            this.txtKeyword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtKeyword.Watermark = "";
            this.txtKeyword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxAuthorizeType
            // 
            this.cbxAuthorizeType.DataSource = null;
            this.cbxAuthorizeType.FillColor = System.Drawing.Color.White;
            this.cbxAuthorizeType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxAuthorizeType.Items.AddRange(new object[] {
            "角色",
            "用户"});
            this.cbxAuthorizeType.Location = new System.Drawing.Point(106, 17);
            this.cbxAuthorizeType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAuthorizeType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxAuthorizeType.Name = "cbxAuthorizeType";
            this.cbxAuthorizeType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxAuthorizeType.Size = new System.Drawing.Size(150, 29);
            this.cbxAuthorizeType.TabIndex = 1;
            this.cbxAuthorizeType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxAuthorizeType.Watermark = "";
            this.cbxAuthorizeType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(23, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "授权类型:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPagination1
            // 
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPagination1.Location = new System.Drawing.Point(13, 443);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.ShowText = false;
            this.uiPagination1.Size = new System.Drawing.Size(604, 35);
            this.uiPagination1.TabIndex = 1;
            this.uiPagination1.Text = "uiPagination1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dg
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dg.BackgroundColor = System.Drawing.Color.White;
            this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle18;
            this.dg.Dock = System.Windows.Forms.DockStyle.Top;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Name = "dg";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dg.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dg.RowTemplate.Height = 23;
            this.dg.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dg.SelectedIndex = -1;
            this.dg.Size = new System.Drawing.Size(800, 435);
            this.dg.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dg.Style = Sunny.UI.UIStyle.Custom;
            this.dg.TabIndex = 0;
            this.dg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AuthorizeManagePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "AuthorizeManagePage";
            this.Text = "授权管理";
            this.Load += new System.EventHandler(this.AuthorizeManagePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Sunny.UI.UISymbolButton btnQuery;
        private Sunny.UI.UITextBox txtKeyword;
        private Sunny.UI.UIComboBox cbxAuthorizeType;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPagination uiPagination1;
        private Sunny.UI.UIDataGridView dg;
    }
}