using BLL;
using Common;
using Entity;
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

namespace Main
{
    public delegate void CustomTreeNodeMouseClickEventHandler(object sender, TreeNodeMouseClickEventArgs e);
   [DataFormAttribute(Description = "菜单管理")]
    public partial class MenuPage : UIPage
    {
        private IModuleBLL modulebll = new ModuleBLL();
        public DataTable menuData = new DataTable();
        public TreeNode currentNode = null;
        private ReloadAsideMenuEventHandler reloadAsideMenuEvent;
        public MenuPage()
        {
            InitializeComponent();
            dg.AutoGenerateColumns = false;
            if (PublicData.Variable.mainForm != null)
            {
                MainForm mainForm = (MainForm)PublicData.Variable.mainForm;
                reloadAsideMenuEvent += mainForm.LoadSideNavigate;
            }
        }

        

       
       

        private void MenuPage_Load(object sender, EventArgs e)
        {
            InitPage();
        }

        private void InitPage()
        {
            //获取菜单数据
            menuData = modulebll.GetTable();
            //加载侧边栏
            InitMenuTree();
            //加载数据
            InitDataGridView();
            //this.btnEdit.Style = UIStyle.LayuiGreen;
            //this.btnDelete.Style = UIStyle.Red;
        }

        private void InitDataGridView()
        {
            menuData.DefaultView.RowFilter = "parentid='0'";
            DataTable moduleData = menuData.DefaultView.ToTable();
            dg.DataSource = moduleData;
        }

        /// <summary>
        /// 初始化树
        /// </summary>
        private void InitMenuTree()
        {

            menuTree.Nodes.Clear();
            foreach (DataRow dr in menuData.Rows)
            {
                if (dr["parentid"].ToString() == "0")
                {
                    //添加父节点(一级菜单)
                    TreeNode pnode = new TreeNode();
                    pnode.Text = dr["fullname"].ToString();
                    pnode.Tag = new MenuTag() { MType = MenuType.ItemOwner,MenuId= dr["moduleid"].ToString(),FullName= dr["fullname"].ToString() };
                    menuTree.Nodes.Add(pnode);
                    //调用方法，添加子级菜单
                    AddChildnode(dr["moduleid"].ToString(), pnode, menuData);
                }
            }
        }

        private void AddChildnode(string moduleid, TreeNode pnode, DataTable moduledt)
        {
            foreach (DataRow datarow in moduledt.Rows)
            {
                if (datarow["parentid"].ToString() == moduleid)
                {
                    TreeNode cnode = new TreeNode();
                    cnode.Text = datarow["fullname"].ToString();
                    pnode.Nodes.Add(cnode);
                    string category = datarow["category"].ToString();
                    if (category == "expand")
                    {
                        cnode.Tag = new MenuTag() { MType = MenuType.ItemOwner, MenuId = datarow["moduleid"].ToString(), FullName = datarow["fullname"].ToString() };
                        //调用本方法，递归
                        AddChildnode(datarow["moduleid"].ToString(), cnode, moduledt);
                    }
                    else if (category == "dataform")
                    {
                        cnode.Tag = new MenuTag() { MType = MenuType.DataForm, MenuId = datarow["moduleid"].ToString(), FullName = datarow["fullname"].ToString(),FormName= datarow["target"].ToString() };
                        
                    }

                }
            }
        }

        private void menuTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;
                currentNode = node;
                //重新加载数据
                string menuId = (currentNode.Tag as MenuTag).MenuId;
                menuData.DefaultView.RowFilter = "parentid='" + menuId + "'";
                var data = menuData.DefaultView.ToTable();
                dg.DataSource = null;
                dg.DataSource = data;
            }
            catch (Exception ex)
            {

                ShowErrorDialog(ex.ToString());
            }
        }
      
        /// <summary>
        /// 保存后刷新数据
        /// </summary>
        /// <param name="node"></param>
        public void RefreshData()
        {
            try
            {
                //重新获取菜单数据
                menuData = modulebll.GetTable();
                //刷新树
                InitMenuTree();
                //刷新表格
                if (currentNode != null)
                {
                    string menuId = (currentNode.Tag as MenuTag).MenuId;
                    menuData.DefaultView.RowFilter = "parentid='" + menuId + "'";
                }
                else
                {
                    menuData.DefaultView.RowFilter = "parentid='0'";
                }
                var data = menuData.DefaultView.ToTable();
                dg.DataSource = null;
                dg.DataSource = data;
                //选中当前节点
                if (currentNode != null)
                {
                    SelectNode((currentNode.Tag as MenuTag).MenuId);
                    menuTree.SelectedNode.Expand();
                }

                ////重新启动
                //System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
                //Application.Exit();
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void SelectNode(string menuId)
        {
            foreach (TreeNode node in menuTree.Nodes)
            {
                MenuTag menuTag = node.Tag as MenuTag;
                if (menuTag.MenuId == menuId)
                {
                    menuTree.SelectedNode = node;
                    break;
                }
                if (node.Nodes.Count > 0)
                {
                    SelectChildNode(node, menuId);
                }
            }
        }
        private void SelectChildNode(TreeNode parentNode,string menuId)
        {
            foreach (TreeNode node in parentNode.Nodes)
            {
                MenuTag menuTag = node.Tag as MenuTag;
                if (menuTag.MenuId == menuId)
                {
                    menuTree.SelectedNode = node;
                    break;
                }
                if (node.Nodes.Count > 0)
                {
                    SelectChildNode(node, menuId);
                }
            }
        }

        //重启系统
        private void Restart(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定重启？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);

                Application.Exit();
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PublicData.MenuInfo.status = "1";
                if (currentNode != null)
                {
                    MenuTag menuTag = (MenuTag)currentNode.Tag;
                    if (menuTag.MType == MenuType.DataForm)
                    {
                        ShowWarningDialog("当前菜单【"+menuTag.FullName+"】为窗体菜单,不能添加子菜单!");
                        return;
                    }
                }
                MenuForm menuForm = new MenuForm(this);
                menuForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                string id = dg.Rows[dg.SelectedIndex].Cells[0].Value.ToString();

                PublicData.MenuInfo.status = "2";
                PublicData.MenuInfo.id = id;
                MenuForm menuForm = new MenuForm(this);
                menuForm.ShowDialog();
            }
            else
            {
                ShowWarningDialog("未选择任何菜单数据");
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                string id = dg.Rows[dg.SelectedIndex].Cells[0].Value.ToString();
                DataRow[] dataRows = menuData.Select("moduleid='" + id + "'");
                DataRow currentRow = dataRows[0];
                if (currentRow["category"].ToString() == "expand")
                {
                    menuData.DefaultView.RowFilter = "parentid='" + id + "'";
                    DataTable dt = menuData.DefaultView.ToTable();
                    if (dt.Rows.Count > 0)
                    {
                        ShowWarningDialog("不能删除有子菜单的父级菜单");
                        return;
                    }

                }
                //删除菜单
                modulebll.Delete(id);
                ShowSuccessTip("删除成功");
                //重新加载数据
                RefreshData();
                reloadAsideMenuEvent();
            }
            else
            {
                ShowWarningDialog("请选择菜单");
            }
        }
    }
}
