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
            get { return "20160526013230_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("StomatoloskaOrdinacija.Model.Pacijent", b =>
                {
                    b.Property<int>("PacijentId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("StatusPacijenta");

                    b.Key("PacijentId");
                });
        }
    }
}
