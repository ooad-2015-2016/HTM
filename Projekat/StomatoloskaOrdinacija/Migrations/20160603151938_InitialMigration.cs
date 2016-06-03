using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace StomatoloskaOrdinacijaMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    OsobljeID = table.Column(type: "INTEGER", nullable: false),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    TipOsoblja = table.Column(type: "TEXT", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                });
            migration.CreateTable(
                name: "Cjenovnik",
                columns: table => new
                {
                    CjenovnikID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Cijena = table.Column(type: "REAL", nullable: false),
                    NazivUsluge = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cjenovnik", x => x.CjenovnikID);
                });
            migration.CreateTable(
                name: "Oprema",
                columns: table => new
                {
                    OpremaID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Kolicina = table.Column(type: "INTEGER", nullable: false),
                    Naziv = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oprema", x => x.OpremaID);
                });
            migration.CreateTable(
                name: "Osoblje",
                columns: table => new
                {
                    OsobljeID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    TipOsoblja = table.Column(type: "TEXT", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoblje", x => x.OsobljeID);
                });
            migration.CreateTable(
                name: "Pacijent",
                columns: table => new
                {
                    PacijentID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Slika = table.Column(type: "image", nullable: true),
                    StatusPacijenta = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacijent", x => x.PacijentID);
                });
            migration.CreateTable(
                name: "Recepcionar",
                columns: table => new
                {
                    RecepcionarID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    OsobljeID = table.Column(type: "INTEGER", nullable: false),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    TipOsoblja = table.Column(type: "TEXT", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepcionar", x => x.RecepcionarID);
                });
            migration.CreateTable(
                name: "Stomatolog",
                columns: table => new
                {
                    StomatologID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    OsobljeID = table.Column(type: "INTEGER", nullable: false),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    TipOsoblja = table.Column(type: "TEXT", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stomatolog", x => x.StomatologID);
                });
            migration.CreateTable(
                name: "ZakazaniTermin",
                columns: table => new
                {
                    ZakazaniTerminID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Termini = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZakazaniTermin", x => x.ZakazaniTerminID);
                });
            migration.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    PacijentIDuKorisnik = table.Column(type: "INTEGER", nullable: false),
                    PacijentPacijentID = table.Column(type: "INTEGER", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Pacijent_PacijentPacijentID",
                        columns: x => x.PacijentPacijentID,
                        referencedTable: "Pacijent",
                        referencedColumn: "PacijentID");
                });
            migration.CreateTable(
                name: "Zahvat",
                columns: table => new
                {
                    ZahvatID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumZahvata = table.Column(type: "TEXT", nullable: false),
                    OpisZahvata = table.Column(type: "TEXT", nullable: true),
                    PacijenIDuZahvatu = table.Column(type: "INTEGER", nullable: false),
                    PacijentPacijentID = table.Column(type: "INTEGER", nullable: true),
                    StomatologIDuZahvatu = table.Column(type: "INTEGER", nullable: false),
                    StomatologStomatologID = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahvat", x => x.ZahvatID);
                    table.ForeignKey(
                        name: "FK_Zahvat_Pacijent_PacijentPacijentID",
                        columns: x => x.PacijentPacijentID,
                        referencedTable: "Pacijent",
                        referencedColumn: "PacijentID");
                    table.ForeignKey(
                        name: "FK_Zahvat_Stomatolog_StomatologStomatologID",
                        columns: x => x.StomatologStomatologID,
                        referencedTable: "Stomatolog",
                        referencedColumn: "StomatologID");
                });
            migration.CreateTable(
                name: "Karton",
                columns: table => new
                {
                    KartonID = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    ZahvatIDuKartonu = table.Column(type: "INTEGER", nullable: false),
                    ZahvatZahvatID = table.Column(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karton", x => x.KartonID);
                    table.ForeignKey(
                        name: "FK_Karton_Zahvat_ZahvatZahvatID",
                        columns: x => x.ZahvatZahvatID,
                        referencedTable: "Zahvat",
                        referencedColumn: "ZahvatID");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Admin");
            migration.DropTable("Cjenovnik");
            migration.DropTable("Karton");
            migration.DropTable("Korisnik");
            migration.DropTable("Oprema");
            migration.DropTable("Osoblje");
            migration.DropTable("Recepcionar");
            migration.DropTable("ZakazaniTermin");
            migration.DropTable("Zahvat");
            migration.DropTable("Pacijent");
            migration.DropTable("Stomatolog");
        }
    }
}
