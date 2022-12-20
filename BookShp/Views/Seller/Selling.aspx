<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Selling.aspx.cs" Inherits="BookShp.Views.Seller.Selling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">

        </div>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center">Book details</h3>
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Book name</label>
                            <input type="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="BNameTb"/>
                        </div>
                    </div>

                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Book price</label>
                            <input type="text" placeholder="Price" autocomplete="off" class="form-control" runat="server" id="BPriceTb"/>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Quantity</label>
                            <input type="text" placeholder="Quantity" autocomplete="off" class="form-control" runat="server" id="BQuanTb"/>
                        </div>
                    </div>

                    <div class="row mt-3 mb-3">
                        <div class="d-grid">
                            <asp:Button Text="AddToBill" runat="server" ID="AddToBill" class="btn-warning btn btn-block" OnClick="AddToBill_Click"/>
                        </div>
                        <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
        
                    </div>
                </div>
                <div class="row mt-5">
                    <h4 class="text-center">Book List</h4>
                    <div class="col">
                        <asp:GridView ID="BList" runat="server" class="table table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="BList_SelectedIndexChanged"></asp:GridView>
                    </div>
                </div>
            </div>
            <div class="col-md-5">
                <h4 class="text-center">Client's Bill</h4>
                    <div class="col">
                        <asp:GridView ID="BillList" runat="server" class="table thread-dark" OnSelectedIndexChanged="BList_SelectedIndexChanged" AutoGenerateSelectButton="True"></asp:GridView>
                        <div class="row">
                            <asp:Label runat="server" ID="GrdTotalTb" class="text-success"></asp:Label>
                        </div>
                        <div class="d-grid">
                            <asp:Button Text="Print" runat="server" ID="PrintBtn" class="btn-warning btn btn-block" OnClick="PrintBtn_Click"/>
                         </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
