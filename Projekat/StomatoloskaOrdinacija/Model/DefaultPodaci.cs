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
                    new Pacijent("Tarik", "Pasalic", new DateTime(1993,12,18)) {PacijentID=1, StatusPacijenta = "Student" }

                     );
                context.SaveChanges();
            }

            if (!context.Administratori.Any())
            {
                context.Administratori.AddRange(new Admin("adnanomerovic", "tuitamo", "Adnan", "Omerovic", new DateTime(1993, 1, 16)) { AdminID = 1 });
                context.SaveChanges();
            }
            if (!context.Cjenovnici.Any())
            {
                context.Cjenovnici.AddRange(new Cjenovnik() { Cijena = 20f, NazivUsluge = "zamjena plombe",CjenovnikID=1 });
                context.SaveChanges();
            }
            if (!context.Kartoni.Any())
            {
                Zahvat tmpZahvat = new Zahvat() { ImeIPrezimePacijenta = "Haris Palic", ImeIPrezimeStomatologa = "Muamer Purisic" };

                Karton tmpKarton = new Karton() { Zahvati = new List<Zahvat>() { tmpZahvat },KartonID=1 };

                context.Kartoni.AddRange( tmpKarton);
                context.SaveChanges();
            }
        }
    }
}
