using System;
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
namespace com.itianchuang.Web.user
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
		com.itianchuang.BLL.user bll=new com.itianchuang.BLL.user();
		com.itianchuang.Model.user model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuser_name.Text=model.user_name;
		this.txtreal_name.Text=model.real_name;
		this.txtpassword.Text=model.password;
		this.txtfk_user_type.Text=model.fk_user_type.ToString();
		this.txtfk_user_group.Text=model.fk_user_group.ToString();
		this.txtis_value.Text=model.is_value.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtuser_name.Text.Trim().Length==0)
			{
				strErr+="user_name不能为空！\\n";	
			}
			if(this.txtreal_name.Text.Trim().Length==0)
			{
				strErr+="real_name不能为空！\\n";	
			}
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="password不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtfk_user_type.Text))
			{
				strErr+="fk_user_type格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfk_user_group.Text))
			{
				strErr+="fk_user_group格式错误！\\n";	
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
			string user_name=this.txtuser_name.Text;
			string real_name=this.txtreal_name.Text;
			string password=this.txtpassword.Text;
			int fk_user_type=int.Parse(this.txtfk_user_type.Text);
			int fk_user_group=int.Parse(this.txtfk_user_group.Text);
			int is_value=int.Parse(this.txtis_value.Text);


			com.itianchuang.Model.user model=new com.itianchuang.Model.user();
			model.id=id;
			model.user_name=user_name;
			model.real_name=real_name;
			model.password=password;
			model.fk_user_type=fk_user_type;
			model.fk_user_group=fk_user_group;
			model.is_value=is_value;

			com.itianchuang.BLL.user bll=new com.itianchuang.BLL.user();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
