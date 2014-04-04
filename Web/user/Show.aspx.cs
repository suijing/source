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
namespace com.itianchuang.Web.user
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		com.itianchuang.BLL.user bll=new com.itianchuang.BLL.user();
		com.itianchuang.Model.user model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbluser_name.Text=model.user_name;
		this.lblreal_name.Text=model.real_name;
		this.lblpassword.Text=model.password;
		this.lblfk_user_type.Text=model.fk_user_type.ToString();
		this.lblfk_user_group.Text=model.fk_user_group.ToString();
		this.lblis_value.Text=model.is_value.ToString();

	}


    }
}
