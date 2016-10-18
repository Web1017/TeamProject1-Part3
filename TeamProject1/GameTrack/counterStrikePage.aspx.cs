using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//required using statements
using TeamProject1;
using TeamProject1.Models;
using System.Web.ModelBinding;

namespace TeamProject1
{
    public partial class counterStrikePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.getCounterStrike();
                
            }

        }

        /// <summary>
        /// This method displays Counter Strike scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getCounterStrike()
        {
            using(GameContextAzure db = new GameContextAzure())
            {
                var csData = (from cStrike in db.GameTable
                              select cStrike);
                CounterStrikeGridView.DataSource = csData.ToList();
                CounterStrikeGridView.DataBind();
            }
        }

        protected void CounterStrikeGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}