using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShp.Views.Admin
{
    public partial class Billings : System.Web.UI.Page
    {
        Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Functions();
            if (!IsPostBack)
            {
                ShowBillings();
            }
        }

        private void ShowBillings()
        {
            string Query = "Select * from BillTB";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();
        }

        protected void BooksList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}