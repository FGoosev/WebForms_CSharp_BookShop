<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="BookShp.Views.Admin.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Books</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Books Title</label>
                    <input type="text" placeholder="Title" autocomplete="off" class="form-control" runat="server" id="BNameTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Books Author</label>
                    <asp:DropDownList runat="server" class="form-control" id="BAuthTb"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Categories</label>
                    <asp:DropDownList  runat="server" class="form-control" id="BCatTb"></asp:DropDownList>       
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Price</label>
                    <input type="text" placeholder="Price" autocomplete="off" class="form-control" runat="server" id="BPriceTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Quantity</label>
                    <input type="text" placeholder="City" autocomplete="off" class="form-control" runat="server" id="BQuantityTb"/>
                </div>

                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" runat="server" ID="BtnUpdateBook" class="btn-warning btn btn-block" OnClick="BtnUpdateBook_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" ID="BtnSaveBook" class="btn-success btn btn-block" OnClick="BtnSaveBook_Click"/>
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" ID="BtnDelBook" class="btn-danger btn btn-block" OnClick="BtnDelBook_Click"/>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:GridView ID="BooksList" runat="server" class="table table-bordered" AutoGenerateSelectButton="True" OnSelectedIndexChanged="BooksList_SelectedIndexChanged"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
