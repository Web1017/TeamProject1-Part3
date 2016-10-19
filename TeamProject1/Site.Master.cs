using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Required of Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace TeamProject1
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                //check if user is logged in
                if(HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    //show GameTrack Area
                    GameTrackPlaceHolder.Visible = true;
                    PublicPlaceHolder.Visible = false;
                }else
                {
                    //only show login and register
                    GameTrackPlaceHolder.Visible = false;
                    PublicPlaceHolder.Visible = true;
                }

            }


            SetActivePage();

        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
               /* case "Home":
                    HomeLink.Attributes.Add("class", "active");
                    break;
                
                case "GameTracker":
                    LoginSignUpLink.Attributes.Add("class", "active");
                    break;
                
                case "Contact":
                    ContactLink.Attributes.Add("class", "active");
                    break;
                    */
            }
        }
    }
}