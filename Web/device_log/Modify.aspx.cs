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
namespace com.itianchuang.Web.device_log
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
		com.itianchuang.BLL.device_log bll=new com.itianchuang.BLL.device_log();
		com.itianchuang.Model.device_log model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtfk_device.Text=model.fk_device.ToString();
		this.txtstate.Text=model.state;
		this.txtchange_time.Text=model.change_time.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtfk_device.Text))
			{
				strErr+="fk_device格式错误！\\n";	
			}
			if(this.txtstate.Text.Trim().Length==0)
			{
				strErr+="state不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtchange_time.Text))
			{
				strErr+="change_time格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int fk_device=int.Parse(this.txtfk_device.Text);
			string state=this.txtstate.Text;
			DateTime change_time=DateTime.Parse(this.txtchange_time.Text);


			com.itianchuang.Model.device_log model=new com.itianchuang.Model.device_log();
			model.id=id;
			model.fk_device=fk_device;
			model.state=state;
			model.change_time=change_time;

			com.itianchuang.BLL.device_log bll=new com.itianchuang.BLL.device_log();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
