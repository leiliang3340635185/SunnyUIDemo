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
    [DataFormAttribute(Description = "用户管理")]
    public partial class UserPage : UIPage
    {
        DataTable data = new DataTable();
        private IUserBLL bll = new UserBLL();
        public UserPage()
        {
            InitializeComponent();
            dg.AutoGenerateColumns = false;
            
        }

       

        private void UserPage_Load(object sender, EventArgs e)
        {

            try
            {
                data = bll.GetTable();
                if (data.Rows.Count > 0)
                {
                    List<base_user> list = data.ToDataList<base_user>();
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
        /// 生成按钮
        /// </summary>
        private void GenerateButttons()
        {

        }


        /// <summary>
        /// 用户查询
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
                string account = txtAccount.Text.Trim();
                string realname = txtRealName.Text.Trim();
                base_user query = new base_user();
                query.account = account;
                query.realname = realname;
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
                    uiPagination1.ActivePage = 0;
                    dg.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }
        /// <summary>
        /// 用户新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 用户编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 用户删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

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

        private void txtAccount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Query();
            }

        }

        private void txtRealName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Query();
            }
        }
    }
}
