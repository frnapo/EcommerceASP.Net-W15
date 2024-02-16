using Ecommerce.Classes;
using System;
namespace Ecommerce

{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // controllo se la pagina non sta facendo un postback
            // ovvero se è la prima volta che viene caricata
            if (!IsPostBack)
            {
                // recupero il carrello dalla sessione
                var carrello = (CarrelloDiAcquisti)Session["CarrelloDiAcquisti"];

                // se non esiste nella sessione, ne viene creato uno nuovo e viene salvato nella var dichiarata sopra
                if (carrello == null)
                {
                    carrello = new CarrelloDiAcquisti();
                    Session["CarrelloDiAcquisti"] = carrello;
                }

                // imposto dataSource del repeater con la lista di articoli del carrello
                // e chiamo metodo DataBind per visualizzare i dati
                RepeaterCarrello.DataSource = carrello.Articoli;
                RepeaterCarrello.DataBind();
            }

            // recupero l'azione e l'ID dalla query string
            // e controllo se l'utente ha cliccato su "rimuovi" o "svuota"
            // se l'utente ha cliccato su "rimuovi" rimuovo l'articolo dal carrello
            // se l'utente ha cliccato su "svuota" svuoto il carrello
            string azione = Request.QueryString["azione"];
            int id;

            if (azione == "rimuovi" && int.TryParse(Request.QueryString["id"], out id))
            {
                var carrello = (CarrelloDiAcquisti)Session["CarrelloDiAcquisti"];
                carrello.Rimuovi(id);
                Session["CarrelloDiAcquisti"] = carrello;
                Response.Redirect("Carrello.aspx");
            }

            else if (azione == "svuota")
            {
                var carrello = (CarrelloDiAcquisti)Session["CarrelloDiAcquisti"];
                carrello.Svuota();
                Session["CarrelloDiAcquisti"] = carrello;
                Response.Redirect("Carrello.aspx");
            }
        }

        protected void btnTornaHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }


    }

}