using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Samuel_Duran_P2_Ap1.Models
{
	public class Vehiculo
	{
		[Key]
		public int VehiculoId { get; set; }

        public int AccesoriosId { get; set; }


        [Required(ErrorMessage = "El campo fecha es obligatorio")]
		public DateTime Fecha { get; set; }

		[Required(ErrorMessage = "El campo descripción es obligatorio")]
		public string? Descripcion { get; set; }

        [Range(1, float.MaxValue, ErrorMessage = "El monto debe ser mayor a 0")]
        public decimal Costos { get; set; }

        [Range(1, float.MaxValue, ErrorMessage = "El monto debe ser mayor a 0")]
        public decimal Gastos { get; set; }
    }
}
