using System;
using System.Collections.Generic;

namespace Ecommerce
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // controllo se non e' un postback
            // imposto il Repeater con la lista di prodotti disponibili e con il binding li renderizzo
            if (!IsPostBack)
            {

                RepeaterProdotti.DataSource = ProductsList.Prodotti;
                RepeaterProdotti.DataBind();
            }
        }

        //dichiaro le proprieta' per prodotto
        public class Prodotto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descrizione { get; set; }
            public decimal Prezzo { get; set; }
            public string UrlImmagine { get; set; }
        }

        // classe statica ProductsList che contiene la lista statica dei prodotti
        public static class ProductsList
        {
            // lista statica accessibile da qualsiasi parte del progetto, ma modificabile solo all'interno della classe
            public static List<Prodotto> Prodotti { get; private set; }

            // costruttore statico che inizializza la lista di prodotti
            static ProductsList()
            {
                Prodotti = new List<Prodotto>
                {
            new Prodotto { Id = 1, Nome = "Beats Pro Red", Descrizione = "Le cuffie Beats Pro sono state progettate per gli ingegneri del suono, musicisti e per coloro che prendono sul serio il suono. Sono le cuffie che Lil Wayne utilizza in studio, e sono progettati per fornire lo stesso livello di emozione e di potenza che l'artista ha inteso originariamente.", Prezzo = 299.99m, UrlImmagine = "./Content/images/beats-pro-red.png" },
            new Prodotto { Id = 2, Nome = "Beats Studio", Descrizione = "Le Beats Studio Pro offrono un suono surround da portare ovunque. Grazie al rilevamento dinamico della posizione della testa, gli avanzati sensori integrati creano un'esperienza interattiva, che ti permette di immergerti nell'audio dei tuoi contenuti preferiti proprio come se fossi al cinema.", Prezzo = 520.00m, UrlImmagine = "./Content/images/beats-studio.png" },
            new Prodotto { Id = 3, Nome = "Hyperx Cloud 2", Descrizione = "Le cuffie Cloud II sono dotate di driver da 53mm e di tipo hi-fi. Si caratterizzano per un'impedenza di 60 ohm e per una risposta in frequenza di 15 – 25.000 Hz. Il loro formato è di tipo Virtual Surround 7.1. Le cuffie sono dotate del connettore USB e sono compatibili con tutte le piattaforme di gioco principali.", Prezzo = 119.99m, UrlImmagine = "./Content/images/hyperx-cloud-2.png" },
            new Prodotto { Id = 4, Nome = "Logitech Headset", Descrizione = "Progettato con e per i giocatori professionisti. L’audio surround 7.1 di nuova generazione e i driver PRO-G da 50 mm assicurano un audio di gioco premium. Il microfono suona in modo sorprendente con la scheda audio USB esterna che integra i filtri di trasmissione Blue VO!CE.", Prezzo = 139.99m, UrlImmagine = "./Content/images/logitech-gaming.png" },
            new Prodotto { Id = 5, Nome = "Logitech Pro", Descrizione = "Fatti sentire, forte e chiaro. Il microfono su braccio PRO da 6 mm rimovibile è dotato di frequenza di risposta più ampia, rapporto segnale-rumore inferiore ed elevata sensibilità, mentre il filtro antipop integrato e lo schermo antivento bloccano i rumori indesiderati.", Prezzo = 199.99m, UrlImmagine = "./Content/images/logitech-pro.png" },
            new Prodotto { Id = 6, Nome = "Noise III", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce scelerisque pulvinar eros, et ultrices ex dictum non. Cras sollicitudin, risus eget posuere rutrum, ipsum ex dapibus elit, interdum malesuada sem dui eget nisi. Nunc varius posuere orci eget sollicitudin.", Prezzo = 359.99m, UrlImmagine = "./Content/images/noise-3.png" },
            new Prodotto { Id = 7, Nome = "Wireless Bass II", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce scelerisque pulvinar eros, et ultrices ex dictum non. Cras sollicitudin, risus eget posuere rutrum, ipsum ex dapibus elit, interdum malesuada sem dui eget nisi. Nunc varius posuere orci eget sollicitudin.", Prezzo = 260.00m, UrlImmagine = "./Content/images/wireless-bass-2.png" },
            new Prodotto { Id = 8, Nome = "Common Headset", Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce scelerisque pulvinar eros, et ultrices ex dictum non. Cras sollicitudin, risus eget posuere rutrum, ipsum ex dapibus elit, interdum malesuada sem dui eget nisi. Nunc varius posuere orci eget sollicitudin.", Prezzo = 99.99m, UrlImmagine = "./Content/images/wireless-headset.png" },
                };
            }
        }
    }
}