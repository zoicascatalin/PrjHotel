using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBase
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Logout_ServerClick(object sender, EventArgs e)
        {
            Login.Visible = true;
            Logout.Visible = false;
            Cache.Remove("username");
            Cache.Remove("password");
        }
    }
}