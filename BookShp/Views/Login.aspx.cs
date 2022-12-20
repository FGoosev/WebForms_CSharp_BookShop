using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShp.Views
{
    public partial class Login : System.Web.UI.Page
    {
        Functions Con;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Functions();
        }

        public static string UName = "";
        public static int User;

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UserEmailTb.Value == "" || PassTb.Value == "")
            {
                ErrMsg.Text = "Missing Data";
            }else if (UserEmailTb.Value == "Admin@admin.ru" && PassTb.Value == "Password")
            {
                Response.Redirect("Admin/Books.aspx");
            }
            else
            {
                string Query = "Select * from SellerTB where SellEmail = '{0}' and SellPass = '{1}' ";
                Query = string.Format(Query, UserEmailTb.Value, PassTb.Value);
                DataTable dt = Con.GetData(Query);
                if(dt.Rows.Count == 0)
                {
                    Response.Redirect("Admin/Books.aspx");
                } else
                {
                    UName = UserEmailTb.Value;
                    User = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Seller/Selling.aspx");
                }
            }
        }
    }
}