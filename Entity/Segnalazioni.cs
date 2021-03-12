using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /*Ogni Segnalazione è riferita a un Prodotto, può avere un numero arbitrario di Commenti ed ha un unico autore,
     che è un utente. Una Segnalazione può essere in vari stati (aperta, presa in carico, risolta), 
    ed ha una data di creazione, una descrizione breve (in non più di 256 caratteri) ed un testo.*/
    public enum Status
    {
        aperta = 1,
        presa_in_carico = 2,
        risolta = 3,
    }
    public class Segnalazioni
    {
        public int SegnalazioniId { get; set; }
        public Status Stato { get; set; }
        public DateTime Creazione { get; set; }

        [StringLength(250)]
        public string Descrizione { get; set; }
        public string Testo { get; set; }
        public int UtentiId { get; set; }
        public int CommentiId { get; set; }
        public int ProdottiId { get; set; }

        public virtual Prodotti Prodotti { get; set; }

        public virtual ICollection<Commenti> Commenti { get; set; }

        public virtual Utenti Utenti { get; set; }

    }
}
