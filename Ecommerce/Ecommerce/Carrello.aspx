<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carrello</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
<link href="Content/style.css" rel="stylesheet" />
</head>
<body>

<form id="form1" runat="server">
    <h1 class="m-0 p-0 mt-4 text-center">Carrello</h1>
    <div class="d-flex mt-3 justify-content-center p-3">
    <asp:Button ID="Button3" runat="server" Text="< Torna alla Home" OnClick="btnTornaHome_Click" CssClass="btn btn-dark rounded-0" />
    <a href="Carrello.aspx?azione=svuota" class="btn btn-warning rounded-0 ms-4 ">Svuota Carrello</a>
     </div>
        <div class="container mt-5">
            <%-- con il repeater assocciato nel file .cs eseguo una sorta di map che mi genera tante card quanti prodotti sono stati aggiunti al carrello --%>
            <asp:Repeater ID="RepeaterCarrello" runat="server">
                <HeaderTemplate>
                    <div class="row">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="col-md-4 mb-4">
                        <div class="card" style="width: 18rem;">
                            <img class="card-img-top" src='<%# Eval("UrlImmagine") %>' alt="Immagine Prodotto">
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Nome") %></h5>
                                <p class="card-text">€<%# Eval("Prezzo") %></p>
                                <a href="Carrello.aspx?azione=rimuovi&id=<%# Eval("Id") %>" class="btn btn-danger">Rimuovi</a>
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
