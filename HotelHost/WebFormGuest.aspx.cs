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
            if (!IsPostBack)
            {
                x = facUsers.GetCamera(Guid.Parse(Cache["UserId"].ToString()));
                pianoNumber.InnerText = x.Piano.ToString();
                cameraNumber.InnerText = x.Stanza.ToString();

                if (x.Temperatura > 30)
                {
                    x.Temperatura = 30;
                    facUsers.SetTemperatura(x);
                }
                else if (x.Temperatura < 10)
                {
                    x.Temperatura = 10;
                    facUsers.SetTemperatura(x);
                }

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
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            facUsers.SetPortaCamera(x);
        }

        protected void btnTemperatura_Click(object sender, EventArgs e)
        {

            x.Temperatura = decimal.Parse(tempControl.Value);

            if (x.Temperatura > 30)
            {
                x.Temperatura = 30;

            }
            else if (x.Temperatura < 10)
            {
                x.Temperatura = 10;

            }

            facUsers.SetTemperatura(x);
            tempControl.Value = x.Temperatura.ToString();


        }
    }
}