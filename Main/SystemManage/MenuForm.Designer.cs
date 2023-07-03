
namespace Main
{
    partial class MenuForm
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.lblTarget = new Sunny.UI.UILabel();
            this.detailPanel = new Sunny.UI.UIPanel();
            this.lblButtons = new Sunny.UI.UILabel();
            this.txtCategoryName = new Sunny.UI.UITextBox();
            this.txtFullName = new Sunny.UI.UITextBox();
            this.cbxTarget = new Sunny.UI.UIComboDataGridView();
            this.txtEncode = new Sunny.UI.UITextBox();
            this.cbxMenuType = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.pmenuTreeView = new Sunny.UI.UIComboTreeView();
            this.actionPanel = new Sunny.UI.UIPanel();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.chkButtons = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.detailPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkButtons)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(287, 46);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(70, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "父菜单:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(267, 94);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(90, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "菜单类型:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(271, 203);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(90, 23);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "菜单编码:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(267, 256);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(90, 23);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "菜单名称:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lblTarget
            // 
            this.lblTarget.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTarget.Location = new System.Drawing.Point(267, 310);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(90, 23);
            this.lblTarget.TabIndex = 7;
            this.lblTarget.Text = "目标窗体:";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTarget.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.chkButtons);
            this.detailPanel.Controls.Add(this.lblButtons);
            this.detailPanel.Controls.Add(this.lblTarget);
            this.detailPanel.Controls.Add(this.txtCategoryName);
            this.detailPanel.Controls.Add(this.txtFullName);
            this.detailPanel.Controls.Add(this.cbxTarget);
            this.detailPanel.Controls.Add(this.uiLabel4);
            this.detailPanel.Controls.Add(this.txtEncode);
            this.detailPanel.Controls.Add(this.uiLabel3);
            this.detailPanel.Controls.Add(this.cbxMenuType);
            this.detailPanel.Controls.Add(this.uiLabel5);
            this.detailPanel.Controls.Add(this.uiLabel2);
            this.detailPanel.Controls.Add(this.pmenuTreeView);
            this.detailPanel.Controls.Add(this.uiLabel1);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detailPanel.Location = new System.Drawing.Point(0, 35);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(900, 573);
            this.detailPanel.TabIndex = 0;
            this.detailPanel.Text = null;
            this.detailPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.detailPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lblButtons
            // 
            this.lblButtons.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblButtons.Location = new System.Drawing.Point(287, 374);
            this.lblButtons.Name = "lblButtons";
            this.lblButtons.Size = new System.Drawing.Size(86, 29);
            this.lblButtons.TabIndex = 13;
            this.lblButtons.Text = "窗体按钮:";
            this.lblButtons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblButtons.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCategoryName.Location = new System.Drawing.Point(393, 149);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.ShowText = false;
            this.txtCategoryName.Size = new System.Drawing.Size(200, 29);
            this.txtCategoryName.TabIndex = 11;
            this.txtCategoryName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCategoryName.Watermark = "";
            this.txtCategoryName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFullName.Location = new System.Drawing.Point(393, 256);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ShowText = false;
            this.txtFullName.Size = new System.Drawing.Size(200, 29);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFullName.Watermark = "";
            this.txtFullName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxTarget
            // 
            this.cbxTarget.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbxTarget.DropDownWidth = 364;
            this.cbxTarget.FillColor = System.Drawing.Color.White;
            this.cbxTarget.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxTarget.Location = new System.Drawing.Point(396, 310);
            this.cbxTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTarget.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxTarget.Name = "cbxTarget";
            this.cbxTarget.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxTarget.Size = new System.Drawing.Size(200, 37);
            this.cbxTarget.TabIndex = 10;
            this.cbxTarget.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxTarget.Watermark = "";
            this.cbxTarget.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEncode
            // 
            this.txtEncode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEncode.Location = new System.Drawing.Point(393, 197);
            this.txtEncode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncode.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.ShowText = false;
            this.txtEncode.Size = new System.Drawing.Size(200, 29);
            this.txtEncode.TabIndex = 6;
            this.txtEncode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEncode.Watermark = "";
            this.txtEncode.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbxMenuType
            // 
            this.cbxMenuType.DataSource = null;
            this.cbxMenuType.FillColor = System.Drawing.Color.White;
            this.cbxMenuType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxMenuType.Items.AddRange(new object[] {
            "expand",
            "dataform"});
            this.cbxMenuType.Location = new System.Drawing.Point(393, 94);
            this.cbxMenuType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMenuType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbxMenuType.Name = "cbxMenuType";
            this.cbxMenuType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbxMenuType.Size = new System.Drawing.Size(200, 29);
            this.cbxMenuType.TabIndex = 4;
            this.cbxMenuType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxMenuType.Watermark = "";
            this.cbxMenuType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cbxMenuType.SelectedValueChanged += new System.EventHandler(this.cbxMenuType_SelectedValueChanged);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(271, 149);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(90, 23);
            this.uiLabel5.TabIndex = 3;
            this.uiLabel5.Text = "类型名称:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pmenuTreeView
            // 
            this.pmenuTreeView.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.pmenuTreeView.FillColor = System.Drawing.Color.White;
            this.pmenuTreeView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pmenuTreeView.Location = new System.Drawing.Point(393, 46);
            this.pmenuTreeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pmenuTreeView.MinimumSize = new System.Drawing.Size(63, 0);
            this.pmenuTreeView.Name = "pmenuTreeView";
            this.pmenuTreeView.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.pmenuTreeView.Size = new System.Drawing.Size(200, 29);
            this.pmenuTreeView.TabIndex = 2;
            this.pmenuTreeView.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pmenuTreeView.Watermark = "";
            this.pmenuTreeView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnCancel);
            this.actionPanel.Controls.Add(this.btnSave);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.actionPanel.Location = new System.Drawing.Point(0, 553);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(900, 55);
            this.actionPanel.TabIndex = 1;
            this.actionPanel.Text = null;
            this.actionPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.actionPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(426, 11);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(340, 11);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkButtons
            // 
            this.chkButtons.Location = new System.Drawing.Point(393, 381);
            this.chkButtons.MultiColumn = true;
            this.chkButtons.Name = "chkButtons";
            this.chkButtons.Size = new System.Drawing.Size(385, 74);
            this.chkButtons.TabIndex = 14;
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 608);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.detailPanel);
            this.Name = "MenuForm";
            this.Text = "菜单";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.detailPanel.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkButtons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel lblTarget;
        private Sunny.UI.UIPanel detailPanel;
        private Sunny.UI.UIComboDataGridView cbxTarget;
        private Sunny.UI.UITextBox txtFullName;
        private Sunny.UI.UITextBox txtEncode;
        private Sunny.UI.UIComboBox cbxMenuType;
        private Sunny.UI.UIComboTreeView pmenuTreeView;
        private Sunny.UI.UIPanel actionPanel;
        private Sunny.UI.UITextBox txtCategoryName;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UILabel lblButtons;
        private DevExpress.XtraEditors.CheckedListBoxControl chkButtons;
    }
}