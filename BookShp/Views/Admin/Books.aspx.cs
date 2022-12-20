using BookShop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShp.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Functions();
            if (!IsPostBack)
            {
                ShowBooks();
                GetCategories();
                GetAuthors();
            }
        }

        private void ShowBooks()
        {
            string Query = "Select * from BookTB";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();

        }
        private void GetCategories()
        {
            string Query = "Select * from CategoryTB";
            BCatTb.DataTextField = Con.GetData(Query).Columns["CatName"].ToString();
            BCatTb.DataValueField = Con.GetData(Query).Columns["CatId"].ToString();
            BCatTb.DataSource = Con.GetData(Query);
            BCatTb.DataBind();
        }

        private void GetAuthors()
        {
            string Query = "Select * from AuthorTB";
            BAuthTb.DataTextField = Con.GetData(Query).Columns["AutName"].ToString();
            BAuthTb.DataValueField = Con.GetData(Query).Columns["AutId"].ToString();
            BAuthTb.DataSource = Con.GetData(Query);
            BAuthTb.DataBind();
        }

        protected void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthTb.SelectedIndex == -1 || BCatTb.SelectedIndex == -1 || BPriceTb.Value == "" || BQuantityTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuthor = BAuthTb.SelectedItem.Value;
                    string BCat = BCatTb.SelectedItem.Value;
                    int BPrice = Convert.ToInt32(BPriceTb.Value);
                    int BQuantity = Convert.ToInt32(BQuantityTb.Value);

                    string Query = "update BookTB set BName = '{0}',BAuthor = '{1}', BCategory = '{2}',BPrice = '{3}', BQuantity = '{4}' where BId = {5}";
                    Query = string.Format(Query, BName, BAuthor, BCat, BPrice, BQuantity, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Book updated";
                    BNameTb.Value = "";
                    BPriceTb.Value = "";
                    BQuantityTb.Value = "";
                    BAuthTb.SelectedIndex= -1;
                    BAuthTb.SelectedIndex= -1;
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void BtnSaveBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthTb.SelectedIndex == -1 || BCatTb.SelectedIndex == -1 || BPriceTb.Value == "" || BQuantityTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string BName = BNameTb.Value;
                    string BAuthor = BAuthTb.SelectedItem.Value.ToString();
                    string BCat = BCatTb.SelectedItem.Value.ToString();
                    int BPrice = Convert.ToInt32(BPriceTb.Value);
                    int BQuantity = Convert.ToInt32(BQuantityTb.Value);

                    string Query = "insert into BookTB values('{0}', '{1}', '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, BName, BAuthor, BCat, BPrice, BQuantity);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Book inserted";
                    BNameTb.Value = "";
                    BPriceTb.Value = "";
                    BQuantityTb.Value = "";
                    BAuthTb.SelectedIndex = -1;
                    BAuthTb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void BtnDelBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == "" || BAuthTb.SelectedIndex == -1 || BCatTb.SelectedIndex == -1 || BPriceTb.Value == "" || BQuantityTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string Query = "delete from BookTB where BId = {0}";
                    Query = string.Format(Query, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Book deleted";
                    BNameTb.Value = "";
                    BPriceTb.Value = "";
                    BQuantityTb.Value = "";
                    BAuthTb.SelectedIndex = -1;
                    BAuthTb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
        int Key = 0;
        protected void BooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BNameTb.Value = BooksList.SelectedRow.Cells[2].Text;
            BAuthTb.SelectedItem.Value = BooksList.SelectedRow.Cells[3].Text;
            BCatTb.SelectedItem.Value = BooksList.SelectedRow.Cells[4].Text;
            BPriceTb.Value = BooksList.SelectedRow.Cells[5].Text;
            BQuantityTb.Value = BooksList.SelectedRow.Cells[6].Text;

            if (BNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BooksList.SelectedRow.Cells[1].Text);
            }
        }
    }
}