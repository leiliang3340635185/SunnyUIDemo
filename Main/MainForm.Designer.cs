
namespace Main
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.asidePanel = new Sunny.UI.UIPanel();
            this.Aside = new Sunny.UI.UINavMenu();
            this.bodyPanel = new Sunny.UI.UIPanel();
            this.tc = new Sunny.UI.UITabControl();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.headPanel = new Sunny.UI.UIPanel();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.menuPasswordModify = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new Sunny.UI.UIPanel();
            this.Header = new Sunny.UI.UINavBar();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.asidePanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.uiContextMenuStrip1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl2
            // 
            resources.ApplyResources(this.splitContainerControl2, "splitContainerControl2");
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.asidePanel);
            resources.ApplyResources(this.splitContainerControl2.Panel1, "splitContainerControl2.Panel1");
            this.splitContainerControl2.Panel2.Controls.Add(this.bodyPanel);
            resources.ApplyResources(this.splitContainerControl2.Panel2, "splitContainerControl2.Panel2");
            this.splitContainerControl2.SplitterPosition = 206;
            // 
            // asidePanel
            // 
            this.asidePanel.Controls.Add(this.Aside);
            resources.ApplyResources(this.asidePanel, "asidePanel");
            this.asidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.asidePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.asidePanel.Name = "asidePanel";
            this.asidePanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.asidePanel.Style = Sunny.UI.UIStyle.Custom;
            this.asidePanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.asidePanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.White;
            this.Aside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Aside, "Aside");
            this.Aside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.Aside.FillColor = System.Drawing.Color.White;
            this.Aside.ForeColor = System.Drawing.Color.Black;
            this.Aside.FullRowSelect = true;
            this.Aside.HoverColor = System.Drawing.Color.LightSkyBlue;
            this.Aside.ItemHeight = 50;
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Name = "Aside";
            this.Aside.SelectedColor = System.Drawing.Color.LightBlue;
            this.Aside.SelectedColor2 = System.Drawing.Color.LightBlue;
            this.Aside.ShowLines = false;
            this.Aside.ShowTips = true;
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            this.Aside.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Aside.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Aside.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Aside_NodeMouseClick);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.tc);
            resources.ApplyResources(this.bodyPanel, "bodyPanel");
            this.bodyPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.bodyPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bodyPanel.Style = Sunny.UI.UIStyle.Custom;
            this.bodyPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bodyPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tc
            // 
            resources.ApplyResources(this.tc, "tc");
            this.tc.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tc.Frame = null;
            this.tc.MainPage = "";
            this.tc.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.ShowCloseButton = true;
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc.Style = Sunny.UI.UIStyle.Custom;
            this.tc.TabBackColor = System.Drawing.Color.White;
            this.tc.TabSelectedColor = System.Drawing.Color.LightSkyBlue;
            this.tc.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.tc.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tc.TipsForeColor = System.Drawing.Color.Black;
            this.tc.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // StyleManager
            // 
            this.StyleManager.Style = Sunny.UI.UIStyle.LayuiGreen;
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.Header);
            resources.ApplyResources(this.headPanel, "headPanel");
            this.headPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.headPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.headPanel.Name = "headPanel";
            this.headPanel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.headPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.headPanel.Style = Sunny.UI.UIStyle.Custom;
            this.headPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.headPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.uiContextMenuStrip1, "uiContextMenuStrip1");
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPasswordModify,
            this.menuExitSystem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // menuPasswordModify
            // 
            this.menuPasswordModify.Name = "menuPasswordModify";
            resources.ApplyResources(this.menuPasswordModify, "menuPasswordModify");
            // 
            // menuExitSystem
            // 
            this.menuExitSystem.Name = "menuExitSystem";
            resources.ApplyResources(this.menuExitSystem, "menuExitSystem");
            this.menuExitSystem.Click += new System.EventHandler(this.menuExitSystem_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.splitContainerControl2);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            this.contentPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.contentPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.contentPanel.Style = Sunny.UI.UIStyle.Custom;
            this.contentPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.contentPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.uiAvatar1);
            resources.ApplyResources(this.Header, "Header");
            this.Header.DropMenuFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Header.ForeColor = System.Drawing.Color.Black;
            this.Header.MenuHoverColor = System.Drawing.Color.LightSkyBlue;
            this.Header.MenuSelectedColor = System.Drawing.Color.LightBlue;
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Name = "Header";
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.ContextMenuStrip = this.uiContextMenuStrip1;
            resources.ApplyResources(this.uiAvatar1, "uiAvatar1");
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headPanel);
            this.Name = "MainForm";
            this.RectColor = System.Drawing.Color.LightSlateGray;
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TitleHeight = 50;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.asidePanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIStyleManager StyleManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private Sunny.UI.UIPanel asidePanel;
        private Sunny.UI.UINavMenu Aside;
        private Sunny.UI.UIPanel bodyPanel;
        private Sunny.UI.UITabControl tc;
        private Sunny.UI.UIPanel headPanel;
        private Sunny.UI.UIPanel contentPanel;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPasswordModify;
        private System.Windows.Forms.ToolStripMenuItem menuExitSystem;
        private Sunny.UI.UINavBar Header;
        private Sunny.UI.UIAvatar uiAvatar1;
    }
}

