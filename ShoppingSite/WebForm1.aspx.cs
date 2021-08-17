using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingSite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;

            int teaCount = int.Parse(ddTeaCount.SelectedValue);
            int coffeeCount = int.Parse(ddCoffeeCount.SelectedValue);

            Session.Add("name", name);
            Session.Add("teaCount", teaCount);
            Session.Add("coffeeCount", coffeeCount);

            int currentSiteTeaCount = 0;

            if (Application["totalTeaCount"] != null)
            {
                currentSiteTeaCount = int.Parse(Application["totalTeaCount"].ToString());                
            }

            int currentSiteCoffeeCount = 0;

            if (Application["totalCoffeeCount"] != null)
            {
                currentSiteCoffeeCount = int.Parse(Application["totalCoffeeCount"].ToString());                
            }

            int totalTeaCount = currentSiteTeaCount + teaCount;
            Application.Set("totalTeaCount", totalTeaCount);

            int totalCoffeeCount = currentSiteCoffeeCount + coffeeCount;
            Application.Set("totalCoffeeCount", totalCoffeeCount);

            Response.Redirect("WebForm2.aspx");
        }
    }
}