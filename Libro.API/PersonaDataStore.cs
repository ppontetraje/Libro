using Libro.API.Models;

namespace Libro.API
{
    public class PersonaDataStore
    {
        public List<PersonaDto> personas { get; set; }
        //public static PersonaDataStore Current { get; } = new PersonaDataStore();

        public PersonaDataStore()
        {
            personas = new List<PersonaDto>()
            {
            new PersonaDto()
            {
                Id= 1,
                Name="Jean Piert",
                LastName="Palomino Quispe"
            },
            new PersonaDto()
            {
                Id= 2,
                Name="Edson Julinho",
                LastName="Quispe Pari"
            }
            };
        }
    }
}
