using BlazorApp.Entities;
namespace BlazorApp.Client.Services
{
    public class RepresentanteService
    {
        private List<RepresentanteVentas> lista;
        public RepresentanteService()
        {
            lista = new List<RepresentanteVentas>();
            lista.Add(new RepresentanteVentas
            {
                Num_Empl = "1",
                Nombre = "Juan Perez",
                Edad = 35,
                Cargo = "Gerente de Ventas",
                FechaContrato = new DateTime(2015, 3, 15),
                Cuota = 100000m,
                Ventas = 120000m
            });
            lista.Add(new RepresentanteVentas
            {
                Num_Empl = "2",
                Nombre = "Maria Gomez",
                Edad = 29,
                Cargo = "Ejecutiva de Ventas",
                FechaContrato = new DateTime(2018, 7, 10),
                Cuota = 80000m,
                Ventas = 85000m
            });
            lista.Add(new RepresentanteVentas
            {
                Num_Empl = "3",
                Nombre = "Carlos Sanchez",
                Edad = 42,
                Cargo = "Supervisor de Ventas",
                FechaContrato = new DateTime(2012, 1, 20),
                Cuota = 120000m,
                Ventas = 110000m
            });
        }
        public List<RepresentanteVentas> listarRepresentantes()
        {
            return lista;
        }
    }
}


