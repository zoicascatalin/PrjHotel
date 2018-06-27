using Facs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBase
{
    public partial class WebFormGuest : System.Web.UI.Page
    {
        Facs.Modelli.UtenteGuest x = new Facs.Modelli.UtenteGuest();

        protected void Page_Load(object sender, EventArgs e)
        {
            x = facUsers.GetCamera("gusso", "gusso");
            pianoNumber.InnerText = x.Piano.ToString();
            cameraNumber.InnerText = x.Stanza.ToString();
            tempControl.Value = x.Temperatura.ToString();
            if (x.StatoPorta)
            {
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
            }
            else
            {
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
            }
        }

        protected void btnOpen_Click(object sender, EventArgs e)
        {
            x.StatoPorta = true;
            btnOpen.Enabled = false;
            btnClose.Enabled = true;
            facUsers.SetPortaCamera(x);
            
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            x.StatoPorta = false;
            btnOpen.Enabled= true;
            btnClose.Enabled = false;
            facUsers.SetPortaCamera(x);
        }
    }
}