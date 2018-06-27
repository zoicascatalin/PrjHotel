using Facs;
using Facs.Modelli;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBase
{
    public partial class Login : System.Web.UI.Page
    {
        Users usr = new Users();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblWrongData.Style.Add("color", "red");
            btnConfirm.Text = "Conferma";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            chkRemember.Text = "Resta Collegato";
            if (Cache != null && Cache["username"] != null && Cache["password"] != null)
            {
                usr = facUsers.UserExists(Cache["username"].ToString(), Cache["password"].ToString());
                if (usr != null)
                {
                    if (usr.Role == 1)
                    {
                        //redirect to Host Page
                        Cache["username"] = txtUsername.Text;
                        Cache["password"] = txtPassword.Text;
                    }
                    else
                    {
                        if (!usr.CheckedOut)
                        {
                            Cache["username"] = txtUsername.Text;
                            Cache["password"] = txtPassword.Text;
                            Server.TransferRequest("WebFormGuest.aspx", true);
                        }
                        else
                        {
                            lblWrongData.Text = "Utente scaduto";
                        }
                    }
                }
                else
                {
                    lblWrongData.Text = "Dati Errati o Utente non Esistente!";
                }
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != null && txtPassword.Text != null)
            {
                usr = facUsers.UserExists(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                lblWrongData.Text = "Dati Errati o Utente non Esistente!";
            }

            if (usr.ID != Guid.Empty)
            {
                if (usr.Role == 1)
                {
                    //redirect to Host Page
                    Cache["username"] = txtUsername.Text;
                    Cache["password"] = txtPassword.Text;
                    Server.TransferRequest("WebFormHost.aspx", true);
                }
                else if(usr.Role == 2)
                {
                    if (!usr.CheckedOut)
                    {
                        Cache["username"] = txtUsername.Text;
                        Cache["password"] = txtPassword.Text;
                        Server.TransferRequest("WebFormGuest.aspx", true);
                    }
                    else
                    {
                        lblWrongData.Text = "Utente scaduto";
                    }
                }
                else
                {
                    lblWrongData.Text = "PROBLEM SOLVING";
                }
            }
            else
            {
                lblWrongData.Text = "Dati Errati o Utente non Esistente!";
            }
        }

        protected void chkRemember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

