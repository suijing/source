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
namespace com.itianchuang.Web.userlog
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
		com.itianchuang.BLL.userlog bll=new com.itianchuang.BLL.userlog();
		com.itianchuang.Model.userlog model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtfk_user.Text=model.fk_user.ToString();
		this.txtbehavior.Text=model.behavior;
		this.txtcontent.Text=model.content;
		this.txttime.Text=model.time.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtfk_user.Text))
			{
				strErr+="fk_user格式错误！\\n";	
			}
			if(this.txtbehavior.Text.Trim().Length==0)
			{
				strErr+="behavior不能为空！\\n";	
			}
			if(this.txtcontent.Text.Trim().Length==0)
			{
				strErr+="content不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int fk_user=int.Parse(this.txtfk_user.Text);
			string behavior=this.txtbehavior.Text;
			string content=this.txtcontent.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);


			com.itianchuang.Model.userlog model=new com.itianchuang.Model.userlog();
			model.id=id;
			model.fk_user=fk_user;
			model.behavior=behavior;
			model.content=content;
			model.time=time;

			com.itianchuang.BLL.userlog bll=new com.itianchuang.BLL.userlog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
