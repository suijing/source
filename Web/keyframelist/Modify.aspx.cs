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
namespace com.itianchuang.Web.keyframelist
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
		com.itianchuang.BLL.keyframelist bll=new com.itianchuang.BLL.keyframelist();
		com.itianchuang.Model.keyframelist model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtfk_video_file.Text=model.fk_video_file.ToString();
		this.txtparent_path.Text=model.parent_path;
		this.txtis_value.Text=model.is_value.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtfk_video_file.Text))
			{
				strErr+="fk_video_file格式错误！\\n";	
			}
			if(this.txtparent_path.Text.Trim().Length==0)
			{
				strErr+="parent_path不能为空！\\n";	
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
			int fk_video_file=int.Parse(this.txtfk_video_file.Text);
			string parent_path=this.txtparent_path.Text;
			int is_value=int.Parse(this.txtis_value.Text);


			com.itianchuang.Model.keyframelist model=new com.itianchuang.Model.keyframelist();
			model.id=id;
			model.fk_video_file=fk_video_file;
			model.parent_path=parent_path;
			model.is_value=is_value;

			com.itianchuang.BLL.keyframelist bll=new com.itianchuang.BLL.keyframelist();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
