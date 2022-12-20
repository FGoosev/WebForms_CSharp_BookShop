<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="BookShp.Views.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Categories</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                
                <div class="mb-3">
                    <label for="" class="form-label text-success">Category Name</label>
                    <input type="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="CatNameTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Category description</label>
                    <input type="text" placeholder="Description" autocomplete="off" class="form-control" runat="server" id="CatDesTb"/>
                </div>
                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" runat="server" class="btn-warning btn btn-block" OnClick="BtnUpdate_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" class="btn-success btn btn-block" OnClick="BtnSave_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" class="btn-danger btn btn-block" OnClick="BtnDelete_Click" />
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:GridView ID="CategoriesList" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CategoriesList_SelectedIndexChanged" class="table table-bordered"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
