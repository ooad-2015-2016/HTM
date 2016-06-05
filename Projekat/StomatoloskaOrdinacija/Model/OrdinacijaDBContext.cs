using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace StomatoloskaOrdinacija.Model
{
    public class OrdinacijaDBContext: DbContext
    {
        public DbSet<Pacijent> Pacijenti { get; set; }
        public DbSet<Cjenovnik> Cjenovnici { get; set; }
        public DbSet<Zahvat> Zahvati { get; set; }
        public DbSet<Karton> Kartoni { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Oprema> Opreme { get; set; }
        public DbSet<Osoblje> Osobljee { get; set; }
        public DbSet<Admin> Administratori { get; set; }
        public DbSet<Recepcionar> Recepcionari { get; set; }
        public DbSet<Stomatolog> Stomatolozi { get; set; }
        public DbSet<ZakazaniTermin> ZakazaniTermini { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dataBaseFilePath = "Ordinacija22.db";
            try
            {
                dataBaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dataBaseFilePath);

            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={dataBaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            modelBuilder.Entity<Pacijent>().Property(p => p.Slika).HasColumnType("image");

        }


    }
}
