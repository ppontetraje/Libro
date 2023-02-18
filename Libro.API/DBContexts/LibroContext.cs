using Libro.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Libro.API.DBContext
{
    public class LibroContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Agency>Agencies { get; set; }
        public DbSet<AgencyAddress> AgencyAddresses { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonAddress> PersonAddresses { get; set; }
        public DbSet<PersonDocument> PersonDocuments { get; set; }

        public LibroContext(DbContextOptions<LibroContext> options) : base(options){}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("ConnectionString");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                new Address()
                {
                    Id= 1,
                    Description="Calle Alberto Arispe 131",
                    Ubigeo = "010101",
                    DateRegistered = DateTime.Now,
                    Latitud=0,
                    Longitud=0,
                    Reference="A media cuadra del óvalo",
                    Status=true
                },
                new Address()
                {
                    Id = 2,
                    Description = "Calle Las fresias",
                    Ubigeo = "010102",
                    DateRegistered = DateTime.Now,
                    Latitud = 0,
                    Longitud = 0,
                    Reference = "A media cuadra de la comisaria",
                    Status = true
                },
                new Address()
                {
                    Id = 3,
                    Description = "Av. Paz Soldán 203",
                    Ubigeo = "010101",
                    DateRegistered = DateTime.Now,
                    Latitud = 0,
                    Longitud = 0,
                    Reference = "A un costado del Hospital de la mujer",
                    Status = true
                },
                new Address()
                {
                    Id = 4,
                    Description = "Av. Independencia 304",
                    Ubigeo = "010102",
                    DateRegistered = DateTime.Now,
                    Latitud = 0,
                    Longitud = 0,
                    Reference = "Intersección con la calle Victor Lira",
                    Status = true
                }
                );
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id= 1,
                    Name="Jean",
                    LastName="Palomino",
                    Genre='M',
                    DateOfBirth=new DateTime(1995,03,09)
                },
                new Person()
                {
                    Id = 2,
                    Name = "Melissa",
                    LastName = "Palomino",
                    Genre = 'F',
                    DateOfBirth = new DateTime(2007, 08, 12)
                },
                new Person()
                {
                    Id = 3,
                    Name = "Edson",
                    LastName = "Quispe",
                    Genre = 'M',
                    DateOfBirth = new DateTime(1995, 01, 17)
                }
                );
            modelBuilder.Entity<DocumentType>().HasData(
                new DocumentType()
                {
                    Id = 1,
                    Name = "Personal"                    
                },
                new DocumentType()
                {
                    Id = 2,
                    Name = "Comercial"                 
                }
                );
            modelBuilder.Entity<Document>().HasData(
                new Document()
                {
                    Id = 1,
                    Name = "Documento Nacional de Identidad",
                    Acronym="DNI",
                    DocumentTypeId=1,
                    HasSerie=false,
                    SunatCode="01"
                },
                new Document()
                {
                    Id = 2,
                    Name = "Registro Unico del Contribuyente",
                    Acronym = "RUC",
                    DocumentTypeId = 1,
                    HasSerie = false,
                    SunatCode = "02"
                }
                );
            modelBuilder.Entity<PersonDocument>().HasData(
                new PersonDocument()
                {
                    Id = 1,
                    DocumentId=1,
                    Serie="",
                    Number="71942776",
                    PersonId=1                    
                },
                new PersonDocument()
                {
                    Id = 2,
                    DocumentId = 1,
                    Serie = "",
                    Number = "81748596",
                    PersonId = 2
                },
                new PersonDocument()
                {
                    Id = 3,
                    DocumentId = 1,
                    Serie = "",
                    Number = "71942774",
                    PersonId = 3
                }
                );
            modelBuilder.Entity<Agency>().HasData(
                new Agency()
                {
                    Id = 1,
                    Name ="La Joya",
                    AgencyType=Enums.AgencyType.DeliverAtHome,
                    PersonId = 1,
                    Status=true
                },
                new Agency()
                {
                    Id = 2,
                    Name = "Independencia",
                    AgencyType = Enums.AgencyType.DeliverAtAgency,
                    PersonId = 2,
                    Status = true
                }
                );
            modelBuilder.Entity<PersonAddress>().HasData(
                new PersonAddress()
                {
                    Id = 1,
                    PersonId = 1,
                    AddressId = 1,
                    IsFiscal = true
                },
                new PersonAddress()
                {
                    Id = 2,
                    PersonId = 2,
                    AddressId = 2,
                    IsFiscal = false
                }
                );
            modelBuilder.Entity<AgencyAddress>().HasData(
                new AgencyAddress()
                {
                    Id = 1,
                    AgencyId = 1,
                    AddressId = 3,
                    Current = true
                },
                new AgencyAddress()
                {
                    Id = 2,
                    AgencyId = 2,
                    AddressId = 4,
                    Current = false
                }
                );
            modelBuilder.Entity<Claim>().HasData(
                new Claim()
                {
                    Id = 1,
                    AgencyId = 1,
                    PersonId = 3,
                    Description = "La mercadería llegó rota",
                    Request="Reparación de la mercadería",
                    Response="",
                    ClaimedAmount=120
                },
                new Claim()
                {
                    Id = 2,
                    AgencyId = 2,
                    PersonId = 3,
                    Description = "El envío se realizó desde Arequipa hacia la joya, la mercadería aún no llega",
                    Request = "Devolución del dinero invertido en el traslado",
                    Response = "",
                    ClaimedAmount = 40
                }
                );
        }




    }
}
