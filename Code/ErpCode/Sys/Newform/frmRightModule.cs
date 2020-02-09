using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sys
{
    public partial class frmRightModule : BaseClass.frmBase
    {
        public frmRightModule()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                BindBigModule();
            }
            btnEdit.Visible = true;
        }

        /// <summary>
        /// 大模块数据绑定
        /// </summary>
        private void BindBigModule()
        {
            string strSQL = "select F_ID,F_Name from t_Right where F_PID = ''";
            DataLib.DataHelper myHelp = new DataLib.DataHelper();
            DataSet ds = myHelp.GetDs(strSQL);
            lookUpEdit1.Properties.DataSource = ds.Tables[0].DefaultView;
            lookUpEdit1.Properties.ValueMember = "F_ID";
            lookUpEdit1.Properties.DisplayMember = "F_Name";

        }

        /// <summary>
        /// 根据大模块取相应小模块
        /// </summary>
        /// <param name="strBigID"></param>
        private void BindModule(string strBigID)
        {
            string strSQL = "select * from t_Right where F_PID = '" + strBigID + "'";
            DataLib.DataHelper myHelp = new DataLib.DataHelper();
            DataSet ds = myHelp.GetDs(strSQL);
            GridModule.DataSource = ds.Tables[0].DefaultView;
        }


        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            BindModule(lookUpEdit1.Properties.GetKeyValueByDisplayText(lookUpEdit1.Text).ToString());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 增加相应权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (gvModule.FocusedRowHandle < 0) return;
            //DataRow drModule = gvModule.GetDataRow(gvModule.FocusedRowHandle);
            //if (gvUser.FocusedRowHandle < 0) return;
            //DataRow dr = gvUser.GetDataRow(gvUser.FocusedRowHandle);
            //frmEditDetailRight myDetailRight = new frmEditDetailRight();
            //myDetailRight.gvGrid = gvUser;
            //myDetailRight.strUser = dr["F_ID"].ToString();
            //myDetailRight.strModule = drModule["F_ID"].ToString();
            //myDetailRight.ShowDialog();
            //myDetailRight.Dispose();
            //BindDetailRight();
            if (lookUpEdit1.Text=="")
            {
                MessageBox.Show("请选择模块");
            }
            else
            {
                frmEditModule myDetailRight = new frmEditModule();
                myDetailRight.strId = "";
                myDetailRight.strName = "";
                myDetailRight.strModule = lookUpEdit1.ItemIndex.ToString();
                myDetailRight.ShowDialog();
                myDetailRight.Dispose();
                BindModule(lookUpEdit1.Properties.GetKeyValueByDisplayText(lookUpEdit1.Text).ToString());
            }
        }

        /// <summary>
        /// 编辑相应权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvModule.FocusedRowHandle < 0) return;
            DataRow dr = gvModule.GetDataRow(gvModule.FocusedRowHandle);
            frmEditModule myDetailRight = new frmEditModule();
            myDetailRight.strId = dr["F_ID"].ToString();
            myDetailRight.strName = dr["F_Name"].ToString();
            myDetailRight.strModule = dr["F_PID"].ToString();
            myDetailRight.ShowDialog();
            myDetailRight.Dispose();
            BindModule(lookUpEdit1.Properties.GetKeyValueByDisplayText(lookUpEdit1.Text).ToString());
        }

        /// <summary>
        /// 删除相关明细权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (gvModule.FocusedRowHandle < 0) return;
            DataRow dr = gvModule.GetDataRow(gvModule.FocusedRowHandle);
            if (MessageBox.Show(this, "真的删除选定用户权限吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            DataLib.DataHelper myHelper = new DataLib.DataHelper();
            if (myHelper.ExecuteSQL("delete from t_Right where F_ID = '" + dr["F_ID"].ToString() + "' and F_Name = '" + dr["F_Name"].ToString() + "'") == 0)
                gvModule.DeleteRow(gvModule.FocusedRowHandle);
        }
    }
}

