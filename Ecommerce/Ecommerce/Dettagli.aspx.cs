using Ecommerce.Classes;
using System;
using System.Linq;
using static Ecommerce.Home;

namespace Ecommerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        // dichiaro variabile protetta che tiene traccia del prodotto selezionato sulla pagina
        protected Prodotto ProdottoSelezionato;

        protected void Page_Load(object sender, EventArgs e)
        {

            // recupero l'ID del prodotto dalla query e cerco il prodotto corrispondente nella lista dei prodotti
            // controllo se esiste un'istanza del carrello 
            // se non esiste, crea una nuova istanza di CarrelloDiAcquisti
            int prodottoId = int.Parse(Request.QueryString["Id"]);
            ProdottoSelezionato = ProductsList.Prodotti.FirstOrDefault(p => p.Id == prodottoId);

            if (Session["CarrelloDiAcquisti"] == null)
            {
                Session["CarrelloDiAcquisti"] = new CarrelloDiAcquisti();
            }
        }


        // metodo invocato quando l'utente clicca sul pulsante "Aggiungi al Carrello"
        // se non e' null aggiunge il prodotto selezionato alla sessione
        protected void btnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            if (ProdottoSelezionato != null)
            {
                var carrello = (CarrelloDiAcquisti)Session["CarrelloDiAcquisti"];
                carrello.Aggiungi(ProdottoSelezionato);
                Session["CarrelloDiAcquisti"] = carrello;

                // mostro messaggio di conferma
                confirmMessage.InnerText = "Prodotto aggiunto al carrello!";

            }
        }


        // metodi per reindirizzare a carrello o home
        protected void btnVaiAlCarrello_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx");
        }

        protected void btnTornaHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}