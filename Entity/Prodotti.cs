using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class Prodotti
    {
        /* Prodotti hanno un codice unico che li caratterizza, un nome commerciale, un nome interno ed una descrizione.
         Inoltre un prodotto può richiederne altri (cioè dipendere da essi per il proprio funzionamento)
         o risultare incompatibile con altri Prodotti.*/
        public int ProdottiId { get; set; }

        public string nomecomm { get; set; }

        public string nomeinterno { get; set; }

        public string Descrizione { get; set; }
    }
}
