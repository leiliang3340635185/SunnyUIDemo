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

namespace Main.SystemManage
{
    public partial class RoleForm : UIForm
    {
        private IRoleBLL bll = new RoleBLL();
        private RolePage parentPage = null;
        private string oldEncode = ""; //旧编号
        private string oldFullname = ""; //旧名称
        private base_role curEntity = new base_role();
        public RoleForm(RolePage parentPage)
        {
            InitializeComponent();
            this.parentPage = parentPage;
            this.MaximizeBox = false;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }
        private void RoleForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (PublicData.RoleInfo.status == "1")
                {

                }
                else if (PublicData.RoleInfo.status == "2")
                {
                    curEntity = bll.GetEntity(PublicData.RoleInfo.id);
                    txtEncode.Text = curEntity.encode;
                    txtFullName.Text = curEntity.fullname;
                    txtDescription.Text = curEntity.description;

                    //修改前的值
                    oldEncode = curEntity.encode;
                    oldFullname= curEntity.fullname;
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //验证数据
                if (!VerifyData())
                {
                    return;
                }
                //保存数据
                curEntity.encode = txtEncode.Text.Trim();
                curEntity.fullname = txtFullName.Text.Trim();
                curEntity.description = txtDescription.Text.Trim();
                if (PublicData.RoleInfo.status == "1")
                {
                    curEntity.roleid = Guid.NewGuid().ToString().Replace("-", "");
                    curEntity.delete_mark = 0;
                    curEntity.create_time = DateTime.Now;
                }
                else if (PublicData.RoleInfo.status == "2")
                {
                    curEntity.update_time = DateTime.Now;
                }
                if (PublicData.RoleInfo.status == "1")
                {
                    bll.Add(curEntity);
                }
                else if (PublicData.RoleInfo.status == "2")
                {
                    bll.Update(curEntity);
                }
                ShowInfoTip("保存成功!");
                this.Close();
                parentPage.RefreshData();
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 验证数据是否有效
        /// </summary>
        /// <returns></returns>
        private bool VerifyData()
        {
            bool result = true;
            string encode = txtEncode.Text.Trim();
            string fullname = txtFullName.Text.Trim();           
            if (string.IsNullOrEmpty(encode))
            {
                ShowWarningDialog("编号不能为空!");
                result = false;
                return result;
            }
            if (string.IsNullOrEmpty(fullname))
            {
                ShowWarningDialog("名称不能为空!");
                result = false;
                return result;
            }

            //角色编号必须唯一
            if (!bll.VerifyEncode(PublicData.RoleInfo.status, oldEncode, encode))
            {
                ShowWarningDialog("编号必须唯一!");
                result = false;
                return result;
            }
            //角色名称必须唯一
            if (!bll.VerifyFullName(PublicData.RoleInfo.status, oldFullname, fullname))
            {
                ShowWarningDialog("名称必须唯一!");
                result = false;
                return result;
            }

            return result;
        }
    }
}
