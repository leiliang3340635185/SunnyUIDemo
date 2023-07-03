using BLL;
using Common;
using IBLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.TabControl;

namespace Main
{
    /// <summary>
    /// 加载侧边栏委托
    /// </summary>
    public delegate void ReloadAsideMenuEventHandler();
    public partial class MainForm : UIForm
    {
        private IModuleBLL modulebll = new ModuleBLL();
        DataTable moduledt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            


           
            this.Text = "主窗体";
            PublicData.Variable.mainForm = this;
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            UIStyles.InitColorful(Color.FromArgb(17,132,158), Color.White);
            //Header导航
            //创建主题导航设置栏
           //AddThemeNavigate();
            //加载侧边导航栏
            LoadSideNavigate();
        }
        /// <summary>
        /// 加载侧边导航栏
        /// </summary>
        public void LoadSideNavigate()
        {
            moduledt = modulebll.GetTable();
            InitSideTree();
          
        }

        /// <summary>
        /// 重新加载侧边导航栏
        /// </summary>
        public void ReloadSideNavigate()
        {
            //InitializeComponent();
            //this.Text = "主窗体";
            //PublicData.Variable.mainForm = this;
            //UIStyles.InitColorful(Color.FromArgb(17, 132, 158), Color.White);
            moduledt = modulebll.GetTable();
            InitSideTree();
        
        }

        private void AddThemeNavigate()
        {
           
            TreeNode themeNode= Header.CreateNode("主题", Guid.NewGuid());
            themeNode.Text = "主题";
            Header.SetNodeSymbol(themeNode, 61502);
          
            var styles = UIStyles.PopularStyles();
            
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(themeNode, style.DisplayText(), style.Value());
            }
            Header.CreateChildNode(themeNode, "多彩主题", UIStyle.Colorful.Value());
            //AddPage(new FColorful());
            //AddPage(new FCommon());
        }

        private void InitSideTree()
        {
            Aside.Nodes.Clear();            
            Header.Nodes.Clear();
            AddThemeNavigate();
            int pageIndex = 1000;
            int i = 1;
            foreach (DataRow dr in moduledt.Rows)
            {
                if (dr["parentid"].ToString() == "0")
                {
                    TreeNode mNode = Aside.CreateNode(dr["fullname"].ToString(), 61451, 24, pageIndex);
                    //TreeNode hNode = new TreeNode();                    
                    //hNode.Text = mNode.Text;
                    //Header.SetNodePageIndex(hNode, pageIndex);
                    //Header.Nodes.Add(hNode);
                    Header.Nodes.Add(mNode.Text);
                    Header.SetNodePageIndex(Header.Nodes[i], pageIndex);
                    Header.SetNodeSymbol(Header.Nodes[i], 61451);
                    mNode.Tag = new MenuTag() { MType = MenuType.ItemOwner, MenuId = dr["moduleid"].ToString(), FullName = dr["fullname"].ToString(), PageIndex =pageIndex };
                    AddSideChildTree(mNode,pageIndex);
                    pageIndex = pageIndex+1000;
                    i++;
                }
            }
        }

        private void AddSideChildTree(TreeNode pNode,int pageIndex)
        {
            foreach (DataRow dataRow in moduledt.Rows)
            {
                if (dataRow["parentid"].ToString() == (pNode.Tag as MenuTag).MenuId)
                {
                    if (dataRow["category"].ToString() == "expand")
                    {
                        TreeNode node = Aside.CreateChildNode(pNode, dataRow["fullname"].ToString(), ++pageIndex);
                        node.Tag = new MenuTag() { MType = MenuType.ItemOwner, MenuId = dataRow["moduleid"].ToString(), FullName = dataRow["fullname"].ToString(), PageIndex = pageIndex };
                        AddSideChildTree(node, pageIndex);
                    }
                    else if(dataRow["category"].ToString() == "dataform")
                    {
                        TreeNode node = Aside.CreateChildNode(pNode, dataRow["fullname"].ToString(), ++pageIndex);                        
                        node.Tag = new MenuTag() { MType = MenuType.DataForm, MenuId = dataRow["moduleid"].ToString(),
                            FormName= dataRow["target"].ToString(),FullName= dataRow["fullname"].ToString(),PageIndex = pageIndex
                        };
                    }
                }  
            }
        }

       
        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0:
                    UIStyle style = (UIStyle)pageIndex;
                    if (style != UIStyle.Colorful)
                        StyleManager.Style = style;
                    else
                        //SelectPage(pageIndex);
                        tc.AddPage(new FColorful());
                    break;
                default:
                    SelectNode(itemText);
                   // Aside.SelectPage(pageIndex); 
                    break;
            }
           
        }


        private void SelectNode(string menuName)
        {
            foreach (TreeNode node in Aside.Nodes)
            {
                MenuTag menuTag = node.Tag as MenuTag;
                if (menuTag.FullName == menuName)
                {
                    Aside.SelectedNode = node;
                    break;
                }
                if (node.Nodes.Count > 0)
                {
                    SelectChildNode(node, menuName);
                }
            }
        }
        private void SelectChildNode(TreeNode parentNode, string menuName)
        {
            foreach (TreeNode node in parentNode.Nodes)
            {
                MenuTag menuTag = node.Tag as MenuTag;
                if (menuTag.FullName == menuName)
                {
                    Aside.SelectedNode = node;
                    break;
                }
                if (node.Nodes.Count > 0)
                {
                    SelectChildNode(node, menuName);
                }
            }
        }

        private void Aside_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;
                MenuTag menuTag = node.Tag as MenuTag;
                MenuType menuType = menuTag.MType;
                if (menuType == MenuType.DataForm)
                {
                    string fullname = menuTag.FormName;
                    if (string.IsNullOrEmpty(fullname))
                    {
                        ShowWarningDialog("请先维护菜单对应的数据窗体");
                        return;
                    }
                    //判断窗体是否已打开
                    List<UIPage> collection = tc.GetPages<UIPage>();
                    foreach (UIPage item in collection)
                    {
                        MenuTag itemTag=(MenuTag)item.Tag;
                        if (itemTag.MenuId == menuTag.MenuId)
                        {
                            ShowInfoTip("窗体已打开");
                            return;
                        }
                    }
                    //打开窗体
                    Type o = Type.GetType(fullname);
                    dynamic obj = Activator.CreateInstance(o, true);
                    UIPage page = (UIPage)obj;
                    page.Tag = menuTag;
                    page.PageIndex = menuTag.PageIndex;
                    tc.AddPage(page);
                    tc.SelectPage(page.PageIndex);
                }
            }
            catch (Exception ex)
            {

                ShowErrorDialog(ex.Message);
            }
        }

        private void headPanel_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics,
            //                    this.headPanel.ClientRectangle,
            //                    Color.LightSeaGreen,//7f9db9
            //                    1,
            //                    ButtonBorderStyle.Solid,
            //                    Color.LightSeaGreen,
            //                    1,
            //                    ButtonBorderStyle.Solid,
            //                    Color.LightSeaGreen,
            //                    1,
            //                    ButtonBorderStyle.Solid,
            //                    Color.LightSeaGreen,
            //                    1,
            //                    ButtonBorderStyle.Solid);
        }

        private void menuExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
