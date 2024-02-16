<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="Ecommerce.Dettagli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Dettagli</title>
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<link href="Content/style.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
<div class="d-flex   justify-content-between">
    <div>
    <asp:Button ID="Button3" runat="server" Text="< Torna alla Home" OnClick="btnTornaHome_Click" CssClass="m-4 btn btn-dark rounded-0 p-2" />
    </div>

    <div>
    <h1 class="m-0 p-0 mt-4 text-center">Epi-Music</h1>
    <h3 class="m-0 p-0 mt-2 text-center">Dettagli prodotto</h3>
    </div>

    <div>
     <asp:Button ID="Button2" runat="server" Text="Vai al Carrello >" OnClick="btnVaiAlCarrello_Click" CssClass="m-4 btn btn-success rounded-0 p-2" />
    </div>
</div>


        <section class="d-flex justify-content-center align-items-center mt-5">
            <div>
                <h2 class="heading-style-2"><%=ProdottoSelezionato.Nome %></h2>
                <p class="custom-description"><%=ProdottoSelezionato.Descrizione %></p>
                <h3 class="heading-style-2">€<%=ProdottoSelezionato.Prezzo %></h3>
                <asp:Button ID="Button1" OnClick="btnAggiungiAlCarrello_Click" Text="Aggiungi al carrello" class="rounded-0 p-3 btn btn-success" runat="server" />  
            </div>

            <div class="ms-5">
                <img class="details-image" src='<%=ProdottoSelezionato.UrlImmagine %>' alt="Immagine Prodotto">
            </div>
        </section>   
    </form>
    <h3 id="confirmMessage" class="fs-4 text-center mt-4" runat="server"></h3>
</body>
</html>
