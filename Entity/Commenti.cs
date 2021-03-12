using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /*Ogni Commento ha un autore, che è un utente,
     una data di creazione non precedente quella della segnalazione di riferimento, ed un testo.*/
   public class Commenti
    {
        public int CommentiId { get; set; }
        public int UtentiId { get; set; }

        public DateTime Creazione { get; set; }

        public string Testo { get; set; }

        public virtual Utenti Utenti { get; set; }
    }
}
