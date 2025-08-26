using BlazorApp.Entities;
namespace BlazorApp.Client.Services
{
    public class RepresentanteService
    {
        private List<RepresentanteList> Lista;
        public RepresentanteService()
        {
            Lista = new List<RepresentanteList>();
            Lista.Add(new RepresentanteList { Num_Empl = 1, Nombre = "Juan Perez" });
            Lista.Add(new RepresentanteList { Num_Empl = 2, Nombre = "Maria Gomez" });
            Lista.Add(new RepresentanteList { Num_Empl = 3, Nombre = "Carlos Sanchez" });
        }
        public List<RepresentanteList> listarRepresentantes()
        {
            return Lista;
        }
    }
}


