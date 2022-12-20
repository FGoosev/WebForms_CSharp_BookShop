<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Seller.aspx.cs" Inherits="BookShp.Views.Admin.Seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col">
                <h3 class="text-center">Manage Sellers</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Name</label>
                    <input type="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="SellNameTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Email</label>
                    <input type="email" placeholder="Email" autocomplete="off" class="form-control" runat="server" id="SellEmailTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Phone</label>
                    <input type="text" placeholder="Phone Number" autocomplete="off" class="form-control" runat="server" id="SellPhoneTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="form-label text-success">Seller Password</label>
                    <input type="password" placeholder="Password" autocomplete="off" class="form-control" runat="server" id="SellPassTb" />
                </div>

                <div class="row">
                    <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                    <div class="col d-grid">
                        <asp:Button Text="Update" runat="server" class="btn-warning btn btn-block" ID="Btn_Update" OnClick="Btn_Update_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" ID="Btn_Save" class="btn-success btn btn-block" OnClick="Btn_Save_Click" />
                    </div>
                    <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" ID="Btn_Delete" class="btn-danger btn btn-block" OnClick="Btn_Delete_Click" />
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:GridView ID="SellersList" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="SellersList_SelectedIndexChanged" class="table table-bordered"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
