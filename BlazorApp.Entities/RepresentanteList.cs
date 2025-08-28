using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    // Asumiendo que existe una clase RepresentanteVentas en el mismo namespace o proyecto
    public class RepresentanteList
    {
        public List<RepresentanteList> Representantes { get; set; } = new();

        [Required(ErrorMessage = "El número de empleado es obligatorio")]
        public string Num_Empl { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Range(18, int.MaxValue, ErrorMessage = "La edad debe ser mayor o igual a 18")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El cargo es obligatorio")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "La fecha de contrato es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime? FechaContrato { get; set; }

        [Required(ErrorMessage = "La cuota es obligatoria")]
        [Range(0, double.MaxValue, ErrorMessage = "La cuota debe ser un número positivo")]
        public decimal Cuota { get; set; }

        [Required(ErrorMessage = "Las ventas son obligatorias")]
        [Range(0, double.MaxValue, ErrorMessage = "Las ventas deben ser un número positivo")]
        public decimal Ventas { get; set; }
    }
}
