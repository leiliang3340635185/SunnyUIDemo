using BLL;
using Common;
using Entity;
using IBLL;
using Main.SystemManage;
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
    [DataFormAttribute(Description ="角色管理")]
    public partial class RolePage : UIPage
    {
        DataTable data = new DataTable();
        private IRoleBLL bll = new RoleBLL();
        public RolePage()
        {
            InitializeComponent();
            dg.AutoGenerateColumns = false;
        }

        private void RolePage_Load(object sender, EventArgs e)
        {
            try
            {
                data = bll.GetTable();
                if (data.Rows.Count > 0)
                {
                    List<base_role> list = data.ToDataList<base_role>();
                    uiPagination1.TotalCount = data.Rows.Count;
                    uiPagination1.ActivePage = 1;
                    var tempList = list.Skip((uiPagination1.ActivePage - 1) * uiPagination1.PageSize).Take(uiPagination1.PageSize).ToList();
                    dg.DataSource = tempList.ToDataTable();
                }
                else
                {
                    dg.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            try
            {
                string encode = txtEncode.Text.Trim();
                string fullname = txtFullName.Text.Trim();
                base_role query = new base_role();
                query.encode = encode;
                query.fullname = fullname;
                var list = bll.GetListLike(query).ToList();
                data = list.ToDataTable();
                if (data.Rows.Count > 0)
                {
                    uiPagination1.TotalCount = data.Rows.Count;
                    uiPagination1.ActivePage = 1;
                    var templist = list.Skip((uiPagination1.ActivePage - 1) * uiPagination1.PageSize).Take(uiPagination1.PageSize).ToList();
                    dg.DataSource = templist.ToDataTable();
                }
                else
                {
                    uiPagination1.TotalCount = 0;
                    dg.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
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
                PublicData.RoleInfo.status = "1";
                RoleForm frm = new RoleForm(this);
                frm.ShowDialog();
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
            try
            {
                if (dg.SelectedRows.Count > 0)
                {
                    string id = dg.Rows[dg.SelectedIndex].Cells[0].Value.ToString();

                    PublicData.RoleInfo.status = "2";
                    PublicData.RoleInfo.id = id;
                    RoleForm frm = new RoleForm(this);
                    frm.ShowDialog();
                }
                else
                {
                    ShowWarningDialog("未选择任何数据");
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg.SelectedRows.Count > 0)
                {
                    string id = dg.Rows[dg.SelectedIndex].Cells[0].Value.ToString();
                    bll.Delete(id);
                    ShowSuccessTip("删除成功");
                    //重新加载数据
                    RefreshData();
                }
                else
                {
                    ShowWarningDialog("未选择任何数据！");
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }

        internal void RefreshData()
        {
            try
            {
                data = bll.GetTable();
                dg.DataSource = data;
            }
            catch (Exception ex)
            {

                ShowErrorDialog(ex.ToString());
            }
        }

        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            if (data.Rows.Count > 0)
            {
                List<base_user> list = data.ToDataList<base_user>();
                var tempList = list.Skip((pageIndex - 1) * uiPagination1.PageSize).Take(uiPagination1.PageSize).ToList();
                dg.DataSource = tempList.ToDataTable();
            }
        }

        private void txtEncode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Query();
            }
        }

        private void txtFullName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Query();
            }
        }
    }
}
