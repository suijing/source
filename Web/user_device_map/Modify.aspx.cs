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
namespace com.itianchuang.Web.user_device_map
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
		com.itianchuang.BLL.user_device_map bll=new com.itianchuang.BLL.user_device_map();
		com.itianchuang.Model.user_device_map model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtfk_user.Text=model.fk_user.ToString();
		this.txtfk_device.Text=model.fk_device.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtfk_user.Text))
			{
				strErr+="fk_user格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfk_device.Text))
			{
				strErr+="fk_device格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int fk_user=int.Parse(this.txtfk_user.Text);
			int fk_device=int.Parse(this.txtfk_device.Text);


			com.itianchuang.Model.user_device_map model=new com.itianchuang.Model.user_device_map();
			model.id=id;
			model.fk_user=fk_user;
			model.fk_device=fk_device;

			com.itianchuang.BLL.user_device_map bll=new com.itianchuang.BLL.user_device_map();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
