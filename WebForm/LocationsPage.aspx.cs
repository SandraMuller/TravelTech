using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.BusinessLayer;
using WebForm.Models;

namespace WebForm
{
    public partial class LocationsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static List<Location> GetLocations(string regionValue)
        {
            BLLocation locations = new BLLocation();
            return locations.GetLocations(regionValue);
        }
    }
}