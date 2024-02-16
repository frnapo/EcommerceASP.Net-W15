using System.Collections.Generic;
using System.Linq;
using static Ecommerce.Home;

namespace Ecommerce.Classes
{
    //creo classe carrello in una cartella Classes
    //per poterla utilizzare in tutte le pagine della web application
    public class CarrelloDiAcquisti
    {
        public List<Prodotto> Articoli { get; set; } = new List<Prodotto>();

        // metodo per aggiungere un prodotto al carrello
        public void Aggiungi(Prodotto prodotto)
        {
            Articoli.Add(prodotto);
        }

        // metodo per rimuovere un prodotto dal carrello tramite l'id
        public void Rimuovi(int idProdotto)
        {
            var prodotto = Articoli.FirstOrDefault(p => p.Id == idProdotto);
            if (prodotto != null)
            {
                Articoli.Remove(prodotto);
            }
        }

        // metodo per svuotare il carrello
        public void Svuota()
        {
            Articoli.Clear();
        }
    }
}