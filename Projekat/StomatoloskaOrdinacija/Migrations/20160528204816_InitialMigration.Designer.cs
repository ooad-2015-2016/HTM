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
            get { return "20160528204816_InitialMigration"; }
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

                    b.Key("KartonID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("KorisnikMobilneAppPacijentID");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.Key("KorisnikID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Oprema", b =>
                {
                    b.Property<int>("OpremaID")
                        .ValueGeneratedOnAdd();

                    b.Key("OpremaID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Osoblje", b =>
                {
                    b.Property<int>("OsobljeID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Key("OsobljeID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Pacijent", b =>
                {
                    b.Property<int>("PacijentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

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

                    b.Property<string>("Username");

                    b.Key("StomatologID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Zahvat", b =>
                {
                    b.Property<int>("ZahvatID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImeIPrezimePacijenta");

                    b.Property<string>("ImeIPrezimeStomatologa");

                    b.Property<int?>("KartonKartonID");

                    b.Key("ZahvatID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.ZakazaniTermin", b =>
                {
                    b.Property<int>("ZakazaniTerminID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ZakazaniTerminiID");

                    b.Key("ZakazaniTerminID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Korisnik", b =>
                {
                    b.Reference("StomatoloskaOrdinacija.Model.Pacijent")
                        .InverseCollection()
                        .ForeignKey("KorisnikMobilneAppPacijentID");
                });

            builder.Entity("StomatoloskaOrdinacija.Model.Zahvat", b =>
                {
                    b.Reference("StomatoloskaOrdinacija.Model.Karton")
                        .InverseCollection()
                        .ForeignKey("KartonKartonID");
                });
        }
    }
}
