using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamProject1
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Page.Title + " loaded...");
            SetActivePage();

        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    HomeLink.Attributes.Add("class", "active");
                    break;
                
                case "GameTracker":
                    LoginSignUpLink.Attributes.Add("class", "active");
                    break;
                
                case "Contact":
                    ContactLink.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}