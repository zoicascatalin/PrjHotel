using Facs;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelHost
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lblWrongData.Style.Add("color", "red");
            btnConfirm.Text = "Conferma";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            checkRememberUsername.Text = "Ricorda nome utente";
            checkStayLogged.Text = "Resta collegato";
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            bool existingUser = false;
            if(txtUsername.Text != null)
            {
                if(txtPassword.Text != null)
                {
                    existingUser = facUsers.UserExists(txtUsername.Text, txtPassword.Text);
                }
                else
                {
                    lblWrongData.Text = "Dati Errati o Utente non Esistente!";
                }
            }
            if (txtUsername.Text != null && txtPassword.Text != null)
            {
                existingUser = facUsers.UserExists(txtUsername.Text, txtPassword.Text);
            }
            if (existingUser)
            {
                System.Diagnostics.Process.Start("https://www.booking.com/hotel/ae/aloft-abu-dhabi.en-gb.html?label=gen173nr-1DCAEoggJCAlhYSDNYBGhxiAEBmAEuwgEKd2luZG93cyAxMMgBDNgBA-gBAZICAXmoAgM;sid=9425a8f638bf05e336438ce36440eefc;dest_id=-782066;dest_type=city;dist=0;hapos=1;hpos=1;room1=A%2CA;sb_price_type=total;srepoch=1529492959;srfid=21e105c4f65a8c4ce023628696fac5828962b0f8X1;srpvid=60804e6f4b430348;type=total;ucfs=1&#hotelTmpl");
            }
            else
            {
                lblWrongData.Text = "Dati Errati o Utente non Esistente!";
            }
        }
    }
}