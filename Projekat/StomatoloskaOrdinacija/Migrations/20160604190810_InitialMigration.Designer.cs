using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using StomatoloskaOrdinacija.Model;

namespace StomatoloskaOrdinacijaMigrations
{
    [ContextType(typeof(OrdinacijaDBContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160604190810_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("StomatoloskaOrdinacija.Model.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<int>("OsobljeID");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<string>("TipOsoblja");

                    b.Property<string>("Username");

                    b.Key("AdminID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Cjenovnik", b =>
                {
                    b.Property<int>("CjenovnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Cijena");

                    b.Property<string>("NazivUsluge");

                    b.Key("CjenovnikID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Karton", b =>
                {
                    b.Property<int>("KartonID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ZahvatIDuKartonu");

                    b.Property<int?>("ZahvatZahvatID");

                    b.Key("KartonID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PacijentIDuKorisnik");

                    b.Property<int?>("PacijentPacijentID");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.Key("KorisnikID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Oprema", b =>
                {
                    b.Property<int>("OpremaID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Kolicina");

                    b.Property<string>("Naziv");

                    b.Key("OpremaID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Osoblje", b =>
                {
                    b.Property<int>("OsobljeID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<string>("TipOsoblja");

                    b.Property<string>("Username");

                    b.Key("OsobljeID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Pacijent", b =>
                {
                    b.Property<int>("PacijentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<byte[]>("Slika")
                        .Annotation("Relational:ColumnType", "image");

                    b.Property<string>("StatusPacijenta");

                    b.Key("PacijentID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Recepcionar", b =>
                {
                    b.Property<int>("RecepcionarID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<int>("OsobljeID");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<string>("TipOsoblja");

                    b.Property<string>("Username");

                    b.Key("RecepcionarID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Stomatolog", b =>
                {
                    b.Property<int>("StomatologID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<int>("OsobljeID");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.Property<string>("TipOsoblja");

                    b.Property<string>("Username");

                    b.Key("StomatologID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Zahvat", b =>
                {
                    b.Property<int>("ZahvatID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumZahvata");

                    b.Property<string>("OpisZahvata");

                    b.Property<int>("PacijenIDuZahvatu");

                    b.Property<int?>("PacijentPacijentID");

                    b.Property<int>("StomatologIDuZahvatu");

                    b.Property<int?>("StomatologStomatologID");

                    b.Key("ZahvatID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.ZakazaniTermin", b =>
                {
                    b.Property<int>("ZakazaniTerminID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PacijentID");

                    b.Property<int>("StomatologID");

                    b.Property<DateTime>("Termini");

                    b.Key("ZakazaniTerminID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Karton", b =>
                {
                    b.Reference("StomatoloskaOrdinacija.Model.Zahvat")
                        .InverseCollection()
                        .ForeignKey("ZahvatZahvatID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Korisnik", b =>
                {
                    b.Reference("StomatoloskaOrdinacija.Model.Pacijent")
                        .InverseCollection()
                        .ForeignKey("PacijentPacijentID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Zahvat", b =>
                {
                    b.Reference("StomatoloskaOrdinacija.Model.Pacijent")
                        .InverseCollection()
                        .ForeignKey("PacijentPacijentID");

                    b.Reference("StomatoloskaOrdinacija.Model.Stomatolog")
                        .InverseCollection()
                        .ForeignKey("StomatologStomatologID");
                });
        }
    }
}
