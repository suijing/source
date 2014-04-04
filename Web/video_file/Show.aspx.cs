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
namespace com.itianchuang.Web.video_file
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
		com.itianchuang.BLL.video_file bll=new com.itianchuang.BLL.video_file();
		com.itianchuang.Model.video_file model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblfile_name.Text=model.file_name;
		this.lblfile_type.Text=model.file_type;
		this.lblfile_path.Text=model.file_path;
		this.lblfile_size.Text=model.file_size.ToString();
		this.lblstart_time.Text=model.start_time.ToString();
		this.lblend_time.Text=model.end_time.ToString();
		this.lblfk_device.Text=model.fk_device.ToString();
		this.lblis_value.Text=model.is_value.ToString();

	}


    }
}
