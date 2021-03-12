using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new UtentiContext())
            {

                var user = c.Utentis.Create();
                user.DataNascita = new DateTime(2000, 1, 1);
              
                c.Utentis.Add(user);
                c.SaveChanges();
            }
        }
    }
}
