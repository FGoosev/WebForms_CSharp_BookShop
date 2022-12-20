using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShp.Views.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Functions();
            ShowSellers();
        }

        private void ShowSellers()
        {
            string Query = "Select * from SellerTB";
            SellersList.DataSource = Con.GetData(Query);
            SellersList.DataBind();
        }
        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellNameTb.Value == "" || SellEmailTb.Value == "" || SellPhoneTb.Value == "" || SellPassTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string SellName = SellNameTb.Value;
                    string SellEmail = SellEmailTb.Value;
                    string SellPhone = SellPhoneTb.Value;
                    string SellPass = SellPassTb.Value;

                    string Query = "update SellerTB set SellName = '{0}',SellEmail = '{1}', SellPhone = '{2}',SellPass = '{3}' where SellId = {4}";
                    Query = string.Format(Query, SellName, SellEmail, SellPhone, SellPass, SellersList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Author updated";
                    SellNameTb.Value = "";
                    SellEmailTb.Value = "";
                    SellPhoneTb.Value = "";
                    SellPassTb.Value = "";

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellNameTb.Value == "" || SellEmailTb.Value == "" || SellPhoneTb.Value == "" || SellPassTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string SellName = SellNameTb.Value;
                    string SellEmail = SellEmailTb.Value;
                    string SellPhone = SellPhoneTb.Value;
                    string SellAddress = SellPassTb.Value;

                    string Query = "insert into SellerTB values('{0}', '{1}', '{2}', '{3}')";
                    Query = string.Format(Query, SellName, SellEmail, SellPhone, SellAddress);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Author inserted";
                    SellNameTb.Value = "";
                    SellEmailTb.Value = "";
                    SellPhoneTb.Value = "";
                    SellPassTb.Value = "";

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellNameTb.Value == "" || SellEmailTb.Value == "" || SellPhoneTb.Value == "" || SellPassTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string Query = "delete from SellerTB where SellId = {0}";
                    Query = string.Format(Query, SellersList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Author inserted";
                    SellNameTb.Value = "";
                    SellEmailTb.Value = "";
                    SellPhoneTb.Value = "";
                    SellPassTb.Value = "";

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        int Key = 0;

        protected void SellersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SellNameTb.Value = SellersList.SelectedRow.Cells[2].Text;
            SellEmailTb.Value = SellersList.SelectedRow.Cells[3].Text;
            SellPhoneTb.Value = SellersList.SelectedRow.Cells[4].Text;
            SellPassTb.Value = SellersList.SelectedRow.Cells[5].Text;

            if (SellNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellersList.SelectedRow.Cells[1].Text);
            }
        }
    }
}