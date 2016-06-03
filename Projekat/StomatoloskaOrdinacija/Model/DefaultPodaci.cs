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
                Pacijent tmpPacijent = new Pacijent("Mujo", "Mujic", new DateTime(1987, 12, 12)) { PacijentID=2,StatusPacijenta="Penzioner" };
                context.Pacijenti.AddRange(tmpPacijent);
                Stomatolog tmpStomatolog = new Stomatolog("kikebudalike", "12345", "Kike", "Budalike", new DateTime(1859, 5, 3)) { StomatologID = 1 };

                context.Stomatolozi.AddRange(tmpStomatolog);

                Osoblje tmpOsoblje = tmpStomatolog;
                tmpOsoblje.OsobljeID = 1;

                context.Osobljee.AddRange(tmpOsoblje);

                Zahvat tmpZahvat = new Zahvat() {OpisZahvata="popravljen zub", Pacijent=tmpPacijent, Stomatolog=tmpStomatolog, PacijenIDuZahvatu=2,StomatologIDuZahvatu=1 };
                context.Zahvati.AddRange(tmpZahvat);

                Karton tmpKarton = new Karton() {KartonID=1, Zahvat=tmpZahvat,ZahvatIDuKartonu=1 };

                context.Kartoni.AddRange( tmpKarton );
                context.SaveChanges();
            }
            if (!context.Korisnici.Any())
            {
                //Korisnik KorisnikMobilneApptmp = new Korisnik() {KorisnikID=2, k };
                Pacijent tmpPacijent = new Pacijent("Nermana", "Suljic", new DateTime(1992, 11, 12)) { StatusPacijenta = "student" };
                context.Pacijenti.AddRange(tmpPacijent);
                

                Korisnik tmpKorisnik = new Korisnik() { KorisnikID = 1, Pacijent=tmpPacijent, Username="nerminasuljic",Password="12345" };
                context.Korisnici.AddRange(tmpKorisnik);
                context.SaveChanges();
            }
            if (!context.Opreme.Any())
            {

                Oprema tempOprema = new Oprema() { OpremaID=1, Kolicina=2,Naziv="plomba"};
                context.Opreme.AddRange(tempOprema);
                context.SaveChanges();
            }
            if (!context.Osobljee.Any())
            {
                Osoblje tmpOsoblje = new Osoblje("Selma", "Sorguc", new DateTime(1995, 10, 29)) { TipOsoblja="Stomatolog",Username="selmasorguc",Password="12345",  };
                context.Osobljee.AddRange(tmpOsoblje);
                context.SaveChanges();
            }
            if (!context.Administratori.Any())
            {
                Admin tmpAdmin = new Admin("hariscubro", "12345", "Haris", "Cubro", new DateTime(1994, 3, 21));
                context.Administratori.AddRange(tmpAdmin);
                context.SaveChanges();
            }
            if (!context.Recepcionari.Any())
            {
                Recepcionar tmpRecepcionar = new Recepcionar("emiruzunovic", "12345", "Emir", "Uzunovic", new DateTime(1993, 5, 6));
                context.Recepcionari.AddRange(tmpRecepcionar);
                context.SaveChanges();
            }
            if (!context.Stomatolozi.Any())
            {
                Stomatolog tmpStomatolog = new Stomatolog("aidabuljkic", "12345", "Aida", "Buljkic", new DateTime(2001, 11, 25));
                context.Stomatolozi.AddRange(tmpStomatolog);
                context.SaveChanges();
            }
            if (!context.ZakazaniTermini.Any())
            {
                ZakazaniTermin tmpZakazaniTermin = new ZakazaniTermin() { ZakazaniTerminID = 1, Termini = new DateTime(2016, 6, 6) };
                context.ZakazaniTermini.AddRange(tmpZakazaniTermin);
                context.SaveChanges();
            }
        }
    }
}
