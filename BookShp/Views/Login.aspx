<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookShp.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="../Assets/lib/css/bootstrap.min.css"/>
</head>
<body>
    <div class="container">
        <div class="row mt-5 mb-5">
            
        </div>
        <div class="row">
            <div class="col-md-4">
                <form id="form1" runat="server">
                    <div>
                        
                    </div>
                    <div class="mt-3">
                        <label for="" class="form-label">User email</label>
                        <input type="email" placeholder="User email" autocomplete="off" class="form-control" runat="server" id="UserEmailTb"/>
                    </div>

                    <div class="mt-3">
                        <label for="" class="form-label">Password</label>
                        <input type="password" placeholder="Password" autocomplete="off" class="form-control" runat="server" id="PassTb"/>
                    </div>
                    <div class="row">
                        <asp:Label runat="server" ID="ErrMsg" class="text-danger"></asp:Label>
                    </div>
                    <div class="mt-3 d-grid">
                        <asp:Button Text="Login" runat="server" class="btn-success btn" ID="LoginBtn" OnClick="LoginBtn_Click" />
                    </div>
                </form>
            </div>
            <div class="col-md-4">

            </div>
        </div>
    </div>
</body>
</html>
