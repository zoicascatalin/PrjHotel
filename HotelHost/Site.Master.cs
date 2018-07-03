using Facs;
using Facs.Modelli;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (Cache != null && Cache["UserId"] != null)
            {
                if (facUsers.IsLogged(Guid.Parse(Cache["UserId"].ToString())))
                {
                    lnkLogin.Visible = false;
                    lnkLogout.Visible = true;
                    lnkAmministrazione.Visible = true;

                }
                else
                {
                    lnkAmministrazione.Visible = false;
                    lnkLogout.Visible = false;
                    lnkLogin.Visible = true;
                }
            }
            else
            {
                lnkAmministrazione.Visible = false;
                lnkLogout.Visible = false;
                lnkLogin.Visible = true;
            }

        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            facUsers.Logout(Guid.Parse(Cache["UserId"].ToString()));
            Cache.Remove("UserId");
            lnkLogout.Visible = false;
            lnkAmministrazione.Visible = false;
            lnkLogin.Visible = true;
            Response.Redirect("Home.aspx");
        }

        protected void CheckUser_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr = facUsers.UserExists(Guid.Parse(Cache["UserId"].ToString()));
            if (usr.Role == 1)
            {
                Response.Redirect("WebFormHost.aspx");
            }
            else if (usr.Role == 2 && !usr.CheckedOut)
            {
                Response.Redirect("WebFormGuest.aspx");
            }
            else
            {
                lnkLogout_Click(null, EventArgs.Empty);
            }
        }
    }
}