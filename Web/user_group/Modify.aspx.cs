﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace com.itianchuang.Web.user_group
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		com.itianchuang.BLL.user_group bll=new com.itianchuang.BLL.user_group();
		com.itianchuang.Model.user_group model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtgroup_name.Text=model.group_name;
		this.txtremark.Text=model.remark;
		this.txtis_value.Text=model.is_value.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtgroup_name.Text.Trim().Length==0)
			{
				strErr+="group_name不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtis_value.Text))
			{
				strErr+="is_value格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string group_name=this.txtgroup_name.Text;
			string remark=this.txtremark.Text;
			int is_value=int.Parse(this.txtis_value.Text);


			com.itianchuang.Model.user_group model=new com.itianchuang.Model.user_group();
			model.id=id;
			model.group_name=group_name;
			model.remark=remark;
			model.is_value=is_value;

			com.itianchuang.BLL.user_group bll=new com.itianchuang.BLL.user_group();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
