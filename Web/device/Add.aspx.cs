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
namespace com.itianchuang.Web.device
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtdevice_name.Text.Trim().Length==0)
			{
				strErr+="device_name不能为空！\\n";	
			}
			if(this.txtip.Text.Trim().Length==0)
			{
				strErr+="ip不能为空！\\n";	
			}
			if(this.txtmac.Text.Trim().Length==0)
			{
				strErr+="mac不能为空！\\n";	
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
			string device_name=this.txtdevice_name.Text;
			string ip=this.txtip.Text;
			string mac=this.txtmac.Text;
			string remark=this.txtremark.Text;
			int is_value=int.Parse(this.txtis_value.Text);

			com.itianchuang.Model.device model=new com.itianchuang.Model.device();
			model.device_name=device_name;
			model.ip=ip;
			model.mac=mac;
			model.remark=remark;
			model.is_value=is_value;

			com.itianchuang.BLL.device bll=new com.itianchuang.BLL.device();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
