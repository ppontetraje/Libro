using Libro.API.Models;

namespace Libro.API
{
    public class AgenciaDataStore
    {
        public List<AgenciaDto> Agencias { get; set; }
        public static AgenciaDataStore Current { get; } = new AgenciaDataStore();

        public AgenciaDataStore()
        {
            Agencias = new List<AgenciaDto>()
            {
            new AgenciaDto()
            {
                Id= 1,
                Name="Independencia",
                Address="Av. independencia #543",
                Email="independencia@logistics.com",
                Reference="Entre la calle Victor Lira y Av. Independencia"
            },
            new AgenciaDto()
            {
                Id= 2,
                Name="La Joya",
                Address="Calle Alberto Arispe #543",
                Email="lajoya@logistics.com",
                Reference="a media cuadra del óvalo"
            }
            };
        }
    }
}
