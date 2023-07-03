
namespace Main.SystemManage
{
    partial class RoleForm
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
            this.btnCancel = new Sunny.UI.UIButton();
            this.actionPanel = new Sunny.UI.UIPanel();
            this.btnSave = new Sunny.UI.UIButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.detailPanel = new Sunny.UI.UIPanel();
            this.txtEncode = new Sunny.UI.UITextBox();
            this.txtFullName = new Sunny.UI.UITextBox();
            this.txtDescription = new Sunny.UI.UITextBox();
            this.actionPanel.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.SuspendLayout();
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
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnCancel);
            this.actionPanel.Controls.Add(this.btnSave);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.actionPanel.Location = new System.Drawing.Point(0, 644);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actionPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(800, 55);
            this.actionPanel.TabIndex = 5;
            this.actionPanel.Text = null;
            this.actionPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.actionPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(234, 76);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(54, 23);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "编号:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(230, 130);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(58, 23);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "名称:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(234, 188);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(58, 23);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "描述:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.txtDescription);
            this.detailPanel.Controls.Add(this.uiLabel1);
            this.detailPanel.Controls.Add(this.txtFullName);
            this.detailPanel.Controls.Add(this.uiLabel4);
            this.detailPanel.Controls.Add(this.txtEncode);
            this.detailPanel.Controls.Add(this.uiLabel3);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.detailPanel.Location = new System.Drawing.Point(0, 35);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(800, 664);
            this.detailPanel.TabIndex = 4;
            this.detailPanel.Text = null;
            this.detailPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.detailPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEncode
            // 
            this.txtEncode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEncode.Location = new System.Drawing.Point(295, 76);
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
            // txtFullName
            // 
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFullName.Location = new System.Drawing.Point(295, 130);
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
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDescription.Location = new System.Drawing.Point(295, 188);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ShowText = false;
            this.txtDescription.Size = new System.Drawing.Size(200, 154);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescription.Watermark = "";
            this.txtDescription.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RoleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.detailPanel);
            this.Name = "RoleForm";
            this.Text = "角色";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.actionPanel.ResumeLayout(false);
            this.detailPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIPanel actionPanel;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel detailPanel;
        private Sunny.UI.UITextBox txtDescription;
        private Sunny.UI.UITextBox txtFullName;
        private Sunny.UI.UITextBox txtEncode;
    }
}