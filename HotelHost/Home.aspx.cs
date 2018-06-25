using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelBase
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnBooking1.Text = "Booking.com";
            btnBooking2.Text = "Booking.com";
            btnBooking3.Text = "Booking.com";
        }
        protected void btnBooking_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.booking.com/hotel/ae/aloft-abu-dhabi.en-gb.html?label=gen173nr-1DCAEoggJCAlhYSDNYBGhxiAEBmAEuwgEKd2luZG93cyAxMMgBDNgBA-gBAZICAXmoAgM;sid=9425a8f638bf05e336438ce36440eefc;dest_id=-782066;dest_type=city;dist=0;hapos=1;hpos=1;room1=A%2CA;sb_price_type=total;srepoch=1529492959;srfid=21e105c4f65a8c4ce023628696fac5828962b0f8X1;srpvid=60804e6f4b430348;type=total;ucfs=1&#hotelTmpl");
        }
    }
}