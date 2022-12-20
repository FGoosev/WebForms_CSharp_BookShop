<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="BookShp.Views.Admin.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Authors</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Author Name</label>
                    <input type="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="ANameTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Author Gender</label>
                    <asp:DropDownList  runat="server" class="form-control" id="GenCb">
                         <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Country</label>
                    <asp:DropDownList ID="CountryCb" runat="server" class="form-control">
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>France</asp:ListItem>
                        <asp:ListItem>Russia</asp:ListItem>
                        <asp:ListItem>Latvia</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>       
                </div>

                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" runat="server" ID="EditBtn" class="btn-warning btn btn-block" OnClick="EditBtn_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" ID="SaveBtn" class="btn-success btn btn-block" OnClick="SaveBtn_Click"/>
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" ID="DeleteBtn" class="btn-danger btn btn-block" OnClick="DeleteBtn_Click" />
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:GridView ID="AuthorsList" runat="server" class="table table-bordered" GridLines="None" CellPadding="4" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged" AutoGenerateSelectButton="True"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
