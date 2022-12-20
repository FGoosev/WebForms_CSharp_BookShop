using BookShop.Models;
using BookShp.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BookShp.Views.Seller
{
    public partial class Selling : System.Web.UI.Page
    {
        Functions Con;

        int Seller = Login.User;
        string SName = Login.UName;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Functions();
            if (!IsPostBack)
            {
                ShowBooks();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5]{
                    new DataColumn("ID"),
                    new DataColumn("Book"),
                    new DataColumn("Price"),
                    new DataColumn("Quantity"),
                    new DataColumn("Total")

                });
                ViewState["Bill"] = dt;
                this.BindGrid();
            }
        }

        protected void BindGrid()
        {
            BillList.DataSource = ViewState["Bill"];
            BillList.DataBind();
        }

        private void ShowBooks()
        {
            string Query = "Select BId as Code, BName as Name, BQuantity as Stock, BPrice as Price from BookTB";
            BList.DataSource = Con.GetData(Query);
            BList.DataBind();

        }

        int Key = 0;
        int Stock = 0;

        protected void BList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BNameTb.Value = BList.SelectedRow.Cells[2].Text;
            Stock = Convert.ToInt32(BList.SelectedRow.Cells[3].Text);
            BPriceTb.Value = BList.SelectedRow.Cells[4].Text;
            

            if (BNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BList.SelectedRow.Cells[1].Text);
            }
        }

        private void UpdateStock()
        {
            
            int NewQty = Convert.ToInt32(BList.SelectedRow.Cells[3].Text) - Convert.ToInt32(BQuanTb.Value);
            string Query = "update BookTB set BQuantity = '{0}' where BId = {1}";
            Query = string.Format(Query,NewQty, BList.SelectedRow.Cells[1].Text);
            Con.SetData(Query);
            ShowBooks();
        }

        int GrdTotal = 0;
        int Amount = 0;
        protected void AddToBill_Click(object sender, EventArgs e)
        {
            if(BQuanTb.Value == "" || BPriceTb.Value == "" || BNameTb.Value == "")
            {
                ErrMsg.Text = "Incorrect data";
            } else
            {
                int total = Convert.ToInt32(BQuanTb.Value) * Convert.ToInt32(BPriceTb.Value);
                DataTable dt = (DataTable)ViewState["Bill"];
                dt.Rows.Add(BillList.Rows.Count + 1, BNameTb.Value.Trim(), BPriceTb.Value.Trim(), BQuanTb.Value.Trim(), total);
                ViewState["Bill"] = dt;
                this.BindGrid();
                UpdateStock();
                GrdTotal = total;
               
                for (int i = 0; i < BillList.Rows.Count - 1; i++)
                {
                    GrdTotal += Convert.ToInt32(BillList.Rows[i].Cells[5].Text);
                }
                Amount = GrdTotal;
                GrdTotalTb.Text = Amount.ToString();
                BNameTb.Value = "";
                BPriceTb.Value = "";
                BQuanTb.Value = "";
                GrdTotal = 0;
            }
        }

        protected void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "insert into BillTB values('{0}', '{1}', '{2}')";
                Query = string.Format(Query, DateTime.Today.Date.ToString(), Seller, Convert.ToInt32(GrdTotalTb.Text));
                Con.SetData(Query);
            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }
    }
}