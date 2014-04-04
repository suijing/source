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
namespace com.itianchuang.Web.device_log
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
		com.itianchuang.BLL.device_log bll=new com.itianchuang.BLL.device_log();
		com.itianchuang.Model.device_log model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblfk_device.Text=model.fk_device.ToString();
		this.lblstate.Text=model.state;
		this.lblchange_time.Text=model.change_time.ToString();

	}


    }
}
