<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ecommerce.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<link href="Content/style.css" rel="stylesheet" />
    <title>E-Commerce</title>
</head>
<body>
    <h1 class="m-0 p-0 mt-4 text-center">Epi-Music</h1>
    <h3 class="m-0 p-0 mt-2 text-center">Your favourite headphones shop!</h3>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <%-- stessa logica per Carrello.aspx --%>
            <asp:Repeater ID="RepeaterProdotti" runat="server">
                <HeaderTemplate>
                    <div class="row">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="col-md-6">
                        <div class="card bg-transparent border-0 shadow mt-3">
                            <div class="d-flex">
                            <div>
                            <img class="card-img-top custom-img p-3" src='<%# Eval("UrlImmagine") %>' alt="headphones">
                            </div>
                            <div class="card-body px-4 position-relative">
                                <h2 class="card-title text-black ms-2 mt-5"><%# Eval("Nome") %></h2>
                                <a href="Dettagli.aspx?Id=<%# Eval("Id") %>" class="btn btn-dark rounded-0 position-absolute bottom-0 ms-4 mb-5">Vai ai Dettagli</a>
                            </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
                <FooterTemplate>
                    </div>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
