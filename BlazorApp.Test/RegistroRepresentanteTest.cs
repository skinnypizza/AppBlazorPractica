using BlazorApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;
using Xunit;
namespace BlazorApp.Test

{
    public class RegistroRepresentanteTest
    {
        private List<ValidationResult> validaModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo, null, null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }
        [Fact]
        public void ValidacionCamposVacios()
        {
            var vendedor = new RepresentanteVentas();

            var errores = validaModelo(vendedor);

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El número de empleado es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El nombre es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La edad debe ser mayor o igual a 18"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El cargo es obligatorio"));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La fecha de contrato es obligatoria"));
        }

        [Fact]
        public void ValidacionEdadInvalida()
        {
            
            var vendedor = new RepresentanteVentas
            {
                Num_Empl = "001",
                Nombre = "Juan Pérez",
                Edad = 17,
                Cargo = "Vendedor",
                FechaContrato = DateTime.Now,
                Cuota = 1000,
                Ventas = 500
            };

            
            var errores = validaModelo(vendedor);

            
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La edad debe ser mayor o igual a 18"));
        }
    }
}