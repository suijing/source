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
namespace com.itianchuang.Web.video_file
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
		com.itianchuang.BLL.video_file bll=new com.itianchuang.BLL.video_file();
		com.itianchuang.Model.video_file model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtfile_name.Text=model.file_name;
		this.txtfile_type.Text=model.file_type;
		this.txtfile_path.Text=model.file_path;
		this.txtfile_size.Text=model.file_size.ToString();
		this.txtstart_time.Text=model.start_time.ToString();
		this.txtend_time.Text=model.end_time.ToString();
		this.txtfk_device.Text=model.fk_device.ToString();
		this.txtis_value.Text=model.is_value.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtfile_name.Text.Trim().Length==0)
			{
				strErr+="file_name不能为空！\\n";	
			}
			if(this.txtfile_type.Text.Trim().Length==0)
			{
				strErr+="file_type不能为空！\\n";	
			}
			if(this.txtfile_path.Text.Trim().Length==0)
			{
				strErr+="file_path不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtfile_size.Text))
			{
				strErr+="file_size格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstart_time.Text))
			{
				strErr+="start_time格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtend_time.Text))
			{
				strErr+="end_time格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfk_device.Text))
			{
				strErr+="fk_device格式错误！\\n";	
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
			string file_name=this.txtfile_name.Text;
			string file_type=this.txtfile_type.Text;
			string file_path=this.txtfile_path.Text;
			decimal file_size=decimal.Parse(this.txtfile_size.Text);
			DateTime start_time=DateTime.Parse(this.txtstart_time.Text);
			DateTime end_time=DateTime.Parse(this.txtend_time.Text);
			int fk_device=int.Parse(this.txtfk_device.Text);
			int is_value=int.Parse(this.txtis_value.Text);


			com.itianchuang.Model.video_file model=new com.itianchuang.Model.video_file();
			model.id=id;
			model.file_name=file_name;
			model.file_type=file_type;
			model.file_path=file_path;
			model.file_size=file_size;
			model.start_time=start_time;
			model.end_time=end_time;
			model.fk_device=fk_device;
			model.is_value=is_value;

			com.itianchuang.BLL.video_file bll=new com.itianchuang.BLL.video_file();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
