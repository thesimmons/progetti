using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class UtentiContext : DbContext
    {
        public UtentiContext() : base()
        {
            Database.SetInitializer<UtentiContext>(new DropCreateDatabaseIfModelChanges<UtentiContext>());
        }

        public DbSet<Utenti> Utentis { get; set; }
    }

    public class Utenti
    {
       public int UtentiId { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime  DataNascita { get; set; }
        //public int eta { get; set; }
        public string  indirizzo { get; set; }
        public string cdf { get; set; }
    }
}
