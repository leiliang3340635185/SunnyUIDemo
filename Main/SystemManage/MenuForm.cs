using BLL;
using Common;
using DevExpress.XtraEditors.Controls;
using Entity;
using IBLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    /// <summary>
    /// 菜单表单
    /// </summary>
    public partial class MenuForm : UIForm
    {
        private IModuleBLL bll = new ModuleBLL();
        private IModuleButtonBLL modulebuttonbll = new ModuleButtonBLL();
        private IFormButtonsBLL formbuttonsbll = new FormButtonsBLL();
        private DataTable menuData = new DataTable();
        private MenuPage menuPage = null;
        private DataTable formButtonsDT = new DataTable();
        /// <summary>
        /// 从新加载主窗体菜单
        /// </summary>
        private ReloadAsideMenuEventHandler reloadAsideMenuEvent;
        private string oldEncode = "";  
        private string oldFullname = "";
        public MenuForm(MenuPage menuPage)
        {
            InitializeComponent();
            this.menuPage = menuPage;
            this.MaximizeBox = false;
            if (PublicData.Variable.mainForm != null)
            {
                MainForm mainForm = (MainForm)PublicData.Variable.mainForm;
                reloadAsideMenuEvent += mainForm.ReloadSideNavigate;
            }
          
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            try
            {
                //初始化控件
                lblTarget.Visible = false;
                cbxTarget.Visible = false;
                lblButtons.Visible = false;
                chkButtons.Visible = false;
                LoadFormButtons();
                //获取菜单数据
                menuData = bll.GetTable();
                //初始化父菜单
                InitMenuTree();
                //加载目标窗体
                LoadTargetForm();
                if (PublicData.MenuInfo.status == "1")
                {
                    this.Text = "菜单新增";
                    //设置父节点
                    if (menuPage.currentNode != null)
                    {
                        SelectNode((menuPage.currentNode.Tag as MenuTag).MenuId);
                    }
                }
                else if (PublicData.MenuInfo.status == "2")
                {
                    this.Text = "菜单编辑";
                    base_module entity = bll.GetEntity(PublicData.MenuInfo.id);
                    if (entity.parentid != "0")
                    {
                        string parentId = bll.GetEntity(entity.parentid).moduleid;
                        SelectNode(parentId); //选中父节点
                    }
                    cbxMenuType.Text = entity.category;
                    txtCategoryName.Text = entity.category_name;
                    txtEncode.Text = entity.encode;
                    txtFullName.Text = entity.fullname;
                    cbxTarget.Text = entity.target;
                    if (cbxMenuType.Text == "dataform")
                    {
                        lblTarget.Visible = true;
                        cbxTarget.Visible = true;
                        lblButtons.Visible = true;
                        chkButtons.Visible = true;
                    }
                    //修改前的值
                    oldEncode = entity.encode;
                    oldFullname = entity.fullname;
                    //
                    var moduleButtonList=modulebuttonbll.GetList(t => t.moduleid == PublicData.MenuInfo.id).OrderBy(t=>t.sortcode).ToList();
                    if (moduleButtonList.Any())
                    {
                        //int index = 0;
                        //foreach (CheckedListBoxItem item in chkButtons.Items)
                        //{
                        //    if (moduleButtonList.Where(t => t.fullname == item.Value.ToString()).Any())
                        //    {
                        //        chkButtons.SetItemChecked(index, true);
                        //    }
                        //    index++;
                        //}

                        foreach (CheckedListBoxItem item in chkButtons.Items)
                        {
                            FormButtonTag tag = (FormButtonTag)item.Tag;
                            if(moduleButtonList.Where(t => t.fullname == tag.FullName.ToString()).Any())
                            {
                                item.CheckState = CheckState.Checked;
                            }
                        }
                    }                    
                }
                
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }          
        }
        /// <summary>
        /// 初始化窗体按钮控件
        /// </summary>
        private void LoadFormButtons()
        {
            formButtonsDT = formbuttonsbll.GetTable();
            if (formButtonsDT.Rows.Count > 0)
            {
                chkButtons.Items.Clear();
                foreach (DataRow dr in formButtonsDT.Rows)
                {
                    //chkButtons.Items.Add(dr["fullname"].ToString(), false);
                    CheckedListBoxItem chkItem = new CheckedListBoxItem();
                    chkItem.Tag = new FormButtonTag
                    {
                        FormButtonId = dr["buttonid"].ToString(),
                        EnCode = dr["encode"].ToString(),
                        FullName = dr["fullname"].ToString(),
                        SortCode = int.Parse(dr["sortcode"].ToString())
                    };
                    chkItem.Value = dr["fullname"].ToString();
                    chkItem.CheckState = CheckState.Unchecked;
                    chkButtons.Items.Add(chkItem);
                }
            }
        }
        /// <summary>
        /// 获取选中的按钮
        /// </summary>
        private DataTable GetSelectFormButtons()
        {
            DataTable dt = formButtonsDT.Clone();
            foreach (CheckedListBoxItem item in chkButtons.CheckedItems)
            {
                FormButtonTag tag = (FormButtonTag)item.Tag;
                foreach (DataRow dataRow in formButtonsDT.Rows)
                {
                    if (tag.FullName.ToString() == dataRow["fullname"].ToString())
                    {
                        dt.Rows.Add(dataRow.ItemArray);
                    }
                }
               
            }
            return dt;
        }
        /// <summary>
        /// 清除选中的窗体按钮
        /// </summary>
        private void ClearCheckedFormButtons()
        {
            int index = 0;
            foreach (CheckedListBoxItem item in chkButtons.Items)
            {

                chkButtons.SetItemChecked(index, false);
                index++;
            }
        }

        private void SelectNode(string menuId)
        {
            foreach (TreeNode node in pmenuTreeView.Nodes)
            {
                MenuTag menuTag = node.Tag as MenuTag;
                if (menuTag.MenuId == menuId)
                {
                    pmenuTreeView.SelectedNode = node;
                    break;
                }
                if (node.Nodes.Count > 0)
                {
                    SelectChildNode(node,menuId);
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
                    pmenuTreeView.SelectedNode = node;
                    break;
                }
                if (node.Nodes.Count > 0)
                {
                    SelectChildNode(node,menuId);
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private bool VerifyData()
        {
            bool flag = true;
            try
            {               
                if (string.IsNullOrEmpty(cbxMenuType.Text.Trim()))
                {
                    ShowWarningDialog("菜单类型不能为空");
                    flag = false;
                }
                if (string.IsNullOrEmpty(txtEncode.Text.Trim()))
                {
                    ShowWarningDialog("编码不能为空");
                    flag = false;
                }
                if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
                {
                    ShowWarningDialog("名称不能为空");
                    flag = false;
                }
                if (cbxMenuType.Text.Trim() == "dataform")
                {
                    if (string.IsNullOrEmpty(cbxTarget.Text.Trim()))
                    {
                        ShowWarningDialog("数据窗体不能为空");
                        flag = false;
                    }
                    if (PublicData.MenuInfo.status == "2")
                    {
                        menuData.DefaultView.RowFilter = "parentid='" + PublicData.MenuInfo.id + "'";
                        DataTable dt = menuData.DefaultView.ToTable();
                        if (dt.Rows.Count > 0)
                        {
                            ShowWarningDialog("当前菜单为父级菜单,且包含子菜单,不能修改为数据窗体菜单！");
                            flag = false;
                        }
                    }
                }
                //菜单编码必须唯一
                if (!bll.VerifyEncode(PublicData.MenuInfo.status,oldEncode,txtEncode.Text.Trim()))
                {
                    ShowWarningDialog("菜单编号必须唯一！");
                    flag = false;
                }
                //菜单名称必须唯一
                if (!bll.VerifyFullName(PublicData.MenuInfo.status, oldFullname, txtFullName.Text.Trim()))
                {
                    ShowWarningDialog("菜单名称必须唯一！");
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
                flag = false; 
            }
            return flag;
        }

       
        /// <summary>
        /// 加载目标窗体
        /// </summary>
        private void LoadTargetForm()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types=assembly.GetTypes();
            //targetDG.AddColumn("窗体标题", "title", 160, DataGridViewContentAlignment.MiddleCenter, true);
            //targetDG.AddColumn("窗体全类名", "fullname", 160, DataGridViewContentAlignment.MiddleCenter, true);
            DataTable targetDT = new DataTable();
            targetDT.Columns.Add("窗体标题");
            targetDT.Columns.Add("窗体全类名");
            foreach (Type type in types)
            {
                Attribute attribute=type.GetCustomAttribute(typeof(DataFormAttribute));
                //if(type.BaseType== typeof(UIPage))
                //{
                //    dynamic obj=Activator.CreateInstance(type);
                //    UIPage page = obj as UIPage;
                //    targetListbox.Items.Add(page.Text);
                //}
                if (attribute != null)
                {
                    dynamic obj = Activator.CreateInstance(type);
                    UIPage page = obj as UIPage;
                    DataRow dr = targetDT.NewRow();
                    dr["窗体标题"] = page.Text;
                    dr["窗体全类名"] = type.FullName;
                    targetDT.Rows.Add(dr);                    
                }
            }
            //targetDG.DataSource = targetDT;
            //cbxTarget.DataGridView.Columns.Add("title", "窗体标题");
            //cbxTarget.DataGridView.Columns.Add("fullname", "窗体全类名");
            //cbxTarget.DataGridView.AutoGenerateColumns = true;
           
            cbxTarget.DataGridView.DataSource = targetDT;
            cbxTarget.DataGridView.Width = 320;
            cbxTarget.DataGridView.Columns["窗体标题"].Width = 160;
            cbxTarget.DataGridView.Columns["窗体全类名"].Width = 160;
            cbxTarget.SelectIndexChange += CbxTarget_SelectIndexChange;
        }

        private void CbxTarget_SelectIndexChange(object sender, int index)
        {
            string value=cbxTarget.DataGridView.Rows[index].Cells["窗体全类名"].Value.ToString();
            cbxTarget.Text = value;
            
        }

        private void CbxTarget_DoEnter(object sender, EventArgs e)
        {
            ShowInfoDialog("哈哈");
        }
        /// <summary>
        /// 初始化树
        /// </summary>
        private void InitMenuTree()
        {


            foreach (DataRow dr in menuData.Rows)
            {
                if (dr["parentid"].ToString() == "0")
                {
                    //添加父节点(一级菜单)
                    TreeNode pnode = new TreeNode();
                    pnode.Text = dr["fullname"].ToString();
                    pnode.Tag = new MenuTag() { MType = MenuType.ItemOwner, MenuId = dr["moduleid"].ToString(), FormName = dr["fullname"].ToString() };
                    pmenuTreeView.Nodes.Add(pnode);
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
                    string category = datarow["category"].ToString();
                    if (category == "expand")
                    {
                        TreeNode cnode = new TreeNode();
                        cnode.Text = datarow["fullname"].ToString();
                        pnode.Nodes.Add(cnode);
                        cnode.Tag = new MenuTag() { MType = MenuType.ItemOwner, MenuId = datarow["moduleid"].ToString(), FormName = datarow["fullname"].ToString() };
                        //调用本方法，递归
                        AddChildnode(datarow["moduleid"].ToString(), cnode, moduledt);
                    }
                    //else if (category == "dataform")
                    //{
                    //    TreeNode cnode = new TreeNode();
                    //    cnode.Text = datarow["fullname"].ToString();
                    //    pnode.Nodes.Add(cnode);
                    //    cnode.Tag = new MenuTag() { MType = MenuType.DataForm, MenuId = datarow["moduleid"].ToString(), FormName = datarow["fullname"].ToString() };
                    //}

                }
            }
        }

        private void cbxMenuType_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = cbxMenuType.SelectedItem.ToString();
            if (value== "dataform")
            {
                txtCategoryName.Text = "数据窗体";
                lblTarget.Visible = true;
                cbxTarget.Visible = true;
                lblButtons.Visible = true;
                chkButtons.Visible = true;
            }
            else if (value == "expand")
            {
                txtCategoryName.Text = "父级菜单";
                cbxTarget.Text = "";
                ClearCheckedFormButtons();
                lblTarget.Visible = false;
                cbxTarget.Visible = false;
                lblButtons.Visible = false;
                chkButtons.Visible = false;
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                //验证数据
                if (!VerifyData())
                {
                    return;
                }
                //保存数据
                base_module entity = new base_module();
                if (PublicData.MenuInfo.status == "1")
                {
                    entity.moduleid = Guid.NewGuid().ToString().Replace("-", "");
                    entity.delete_mark = 0;
                    entity.create_time = DateTime.Now;
                }
                else if (PublicData.MenuInfo.status == "2")
                {
                    entity = bll.GetEntity(PublicData.MenuInfo.id);
                    entity.update_time = DateTime.Now;
                }

                entity.parentid = "0";
                TreeNode pNode = pmenuTreeView.SelectedNode;
                if (pNode != null)
                {
                    MenuTag menuTag = pNode.Tag as MenuTag;
                    entity.parentid = menuTag.MenuId;
                }
                if (cbxMenuType.Text.Trim() == "expand")
                {
                    entity.category_name = "父级菜单";
                    entity.ismenu = 0;
                    cbxTarget.Text = "";
                    entity.target = "";
                }
                else if (cbxMenuType.Text.Trim() == "dataform")
                {
                    entity.category_name = "数据窗体";
                    entity.ismenu = 1;
                }
                entity.encode = txtEncode.Text.Trim();
                entity.fullname = txtFullName.Text.Trim();
                entity.category = cbxMenuType.Text.Trim();                
                entity.target = cbxTarget.Text;
                int result = 0;
               
                if (PublicData.MenuInfo.status == "1")
                {
                    //保存菜单
                    result = bll.Add(entity);                   
                }
                else if (PublicData.MenuInfo.status == "2")
                {
                    //保存菜单
                    result = bll.Update(entity);                   
                }
                //保存菜单按钮
                DataTable dt = GetSelectFormButtons();
                modulebuttonbll.Save(PublicData.MenuInfo.status, dt, entity.moduleid);
                //if (dt.Rows.Count > 0)
                //{
                //    modulebuttonbll.Save(PublicData.MenuInfo.status, dt, entity.moduleid);
                //}
               
                ShowSuccessTip("保存成功");
                this.Close();
                menuPage.RefreshData();
                reloadAsideMenuEvent();
                   
              
            }
            catch (Exception ex)
            {

                ShowErrorDialog(ex.Message);
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
