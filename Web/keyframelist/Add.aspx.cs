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
			int id=int.Parse(this.txtid.Text);
			int fk_video_file=int.Parse(this.txtfk_video_file.Text);
			string parent_path=this.txtparent_path.Text;
			int is_value=int.Parse(this.txtis_value.Text);

			com.itianchuang.Model.keyframelist model=new com.itianchuang.Model.keyframelist();
			model.id=id;
			model.fk_video_file=fk_video_file;
			model.parent_path=parent_path;
			model.is_value=is_value;

			com.itianchuang.BLL.keyframelist bll=new com.itianchuang.BLL.keyframelist();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
