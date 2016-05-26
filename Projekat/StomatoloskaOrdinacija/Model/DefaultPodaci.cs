using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class DefaultPodaci
    {
        public static void Initialize(OrdinacijaDBContext context)
        {
            if (!context.Pacijenti.Any())
            {
                context.Pacijenti.AddRange(
                    //NE RADI Convert.ToDateTime("18/12/1992")
                    new Pacijent("Tarik", "Pasalic", new DateTime(1993,12,18)) { StatusPacijenta = "Student" }

                     );
                context.SaveChanges();
            }
        }
    }
}
