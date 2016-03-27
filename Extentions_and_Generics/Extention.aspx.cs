using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Extentions_and_Generics
{
    public partial class Extention : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(cblTest.Items.AsEnumareble().Any(x => !x.Selected))
            {
                litReturn.Text = "You did'nt select all values.";
            }
            else
            {
                litReturn.Text = "You selected all values.";
            }
            //litReturn.Text = (cblTest.Items.AsEnumareble().Any(x => !x.Selected)) ? "You did'nt select all values." : "You selected all values.";
        }
    }

    /// <summary>
    /// Extention methods require a static class
    /// </summary>
    public static class Extentions
    {
        /// <summary>
        /// Extention method
        /// </summary>
        /// <param name="l">
        /// Notice the keywork 'this'. 
        /// This keyword is what makes a method be an extention method, in this case to all ListItemCollection objects in this project
        /// </param>
        /// <returns>
        /// Using yield returns each element one at a time and the current location in code is retained. Execution is restarted from that location.
        /// </returns>
        public static IEnumerable<ListItem> AsEnumareble(this ListItemCollection l)
        {
            foreach(ListItem c in l)
            {
                yield return c;
            }
        }
    }
}