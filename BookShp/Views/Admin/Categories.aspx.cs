using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShp.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Functions();
            ShowCategories();
        }

        private void ShowCategories()
        {
            string Query = "Select * from CategoryTB";
            CategoriesList.DataSource = Con.GetData(Query);
            CategoriesList.DataBind();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || CatDesTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string CatName = CatNameTb.Value;
                    string CatDes = CatDesTb.Value;

                    string Query = "update CategoryTB set CatName = '{0}',CatDescription = '{1}' where CatId = {2}";
                    Query = string.Format(Query, CatName, CatDes, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category updated";
                    CatNameTb.Value = "";
                    CatDesTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || CatDesTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string CatName = CatNameTb.Value;
                    string CatDes = CatDesTb.Value;

                    string Query = "insert into CategoryTB values('{0}', '{1}')";
                    Query = string.Format(Query, CatName, CatDes);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category inserted";
                    CatNameTb.Value = "";
                    CatDesTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || CatDesTb.Value == "")
                {
                    ErrMsg.Text = "Missing Data";
                }
                else
                {
                    string CatName = CatNameTb.Value;
                    string CatDes = CatDesTb.Value;

                    string Query = "delete from CategoryTB where CatId = {0}";
                    Query = string.Format(Query, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category deleted";
                    CatNameTb.Value = "";
                    CatDesTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
        int Key = 0;

        protected void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoriesList.SelectedRow.Cells[2].Text;
            CatDesTb.Value = CategoriesList.SelectedRow.Cells[3].Text;
            if (CatNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesList.SelectedRow.Cells[1].Text);
            }
        }
    }
}