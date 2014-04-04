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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtid.Text))
			{
				strErr+="id格式错误！\\n";	
			}
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
			int id=int.Parse(this.txtid.Text);
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
