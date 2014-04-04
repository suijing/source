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
namespace com.itianchuang.Web.keyframelist
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
		com.itianchuang.BLL.keyframelist bll=new com.itianchuang.BLL.keyframelist();
		com.itianchuang.Model.keyframelist model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblfk_video_file.Text=model.fk_video_file.ToString();
		this.lblparent_path.Text=model.parent_path;
		this.lblis_value.Text=model.is_value.ToString();

	}


    }
}
