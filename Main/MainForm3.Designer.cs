
namespace Main
{
    partial class MainForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm3));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.headPanel = new Sunny.UI.UIPanel();
            this.Header = new Sunny.UI.UINavBar();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.asidePanel = new Sunny.UI.UIPanel();
            this.Aside = new Sunny.UI.UINavMenu();
            this.bodyPanel = new Sunny.UI.UIPanel();
            this.tc = new Sunny.UI.UITabControl();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.asidePanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.headPanel);
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.SplitterPosition = 56;
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.Header);
            resources.ApplyResources(this.headPanel, "headPanel");
            this.headPanel.Name = "headPanel";
            this.headPanel.Radius = 1;
            this.headPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.headPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Header, "Header");
            this.Header.DropMenuFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Header.ForeColor = System.Drawing.Color.Black;
            this.Header.MenuHoverColor = System.Drawing.Color.LightSkyBlue;
            this.Header.MenuSelectedColor = System.Drawing.Color.LightBlue;
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Name = "Header";
            this.Header.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // splitContainerControl2
            // 
            resources.ApplyResources(this.splitContainerControl2, "splitContainerControl2");
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.asidePanel);
            this.splitContainerControl2.Panel2.Controls.Add(this.bodyPanel);
            this.splitContainerControl2.SplitterPosition = 195;
            // 
            // asidePanel
            // 
            this.asidePanel.Controls.Add(this.Aside);
            resources.ApplyResources(this.asidePanel, "asidePanel");
            this.asidePanel.Name = "asidePanel";
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
            this.Aside.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Aside.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Aside.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Aside_NodeMouseClick);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.tc);
            resources.ApplyResources(this.bodyPanel, "bodyPanel");
            this.bodyPanel.Name = "bodyPanel";
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
            // MainForm3
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MainForm3";
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.TitleHeight = 50;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.asidePanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIStyleManager StyleManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private Sunny.UI.UINavBar Header;
        private Sunny.UI.UIPanel headPanel;
        private Sunny.UI.UIPanel bodyPanel;
        private Sunny.UI.UIPanel asidePanel;
        private Sunny.UI.UINavMenu Aside;
        private Sunny.UI.UITabControl tc;
    }
}

