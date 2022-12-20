<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Billings.aspx.cs" Inherits="BookShp.Views.Admin.Billings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8">
                <asp:GridView ID="BooksList" runat="server" class="table table-bordered"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
