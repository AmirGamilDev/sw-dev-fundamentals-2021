using System;

namespace PageEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToLocalTime().ToString();

            Response.Write($"<p>Message from Page_Load at {now}</p>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToLocalTime().ToString();

            Response.Write($"<p>Message from Page_Init at {now}</p>");
        }

        protected void Page_DataBind(object sender, EventArgs e)
        {
            Response.Write("<p>Message from Page_DataBind.<p>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            System.Console.WriteLine("In Page_Unload");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToLocalTime().ToString();

            Response.Write($"<p>Message from Page_PreRender at {now}</p>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToLocalTime().ToString();

            Response.Write($"<p>Message from Page_PreInit at {now}</p>");
        }

        protected void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if(name.Length > 0)
            {
                lblGreeting.Text = $"Hello {name}!";
            }
            else
            {
                lblGreeting.Text = "Hello world!";
            }

        }
    }
}