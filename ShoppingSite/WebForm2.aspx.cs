using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                lblGreeting.Text = $"Hi {Session["name"]}!";
            }

            if(Session["teaCount"] != null)
            {
                string output = $"You are buying {Session["teaCount"]} box";

                if ((int)Session["teaCount"] > 1)
                {
                    output += "es";
                }

                output += $" of tea - Total tea sales in progress across website: { Application["totalTeaCount"]}";

                lblTeaStatus.Text = output;
            }

            if (Session["coffeeCount"] != null)
            {
                string output = $"You are buying {Session["coffeeCount"]} jar";

                if ((int)Session["coffeeCount"] > 1)
                {
                    output += "s";
                }

                output += $" of coffee - Total coffee sales in progress across website: { Application["totalCoffeeCount"]}";                

                lblCoffeeStatus.Text = output;
            }
        }
    }
}