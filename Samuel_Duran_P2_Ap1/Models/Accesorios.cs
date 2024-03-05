using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Samuel_Duran_P2_Ap1.Models
{
	public class Accesorios
	{
		[Key]

        public int AccesoriosId { get; set; }

		[Required(ErrorMessage = "El campo descripción es obligatorio")]
		public string? Descripcion { get; set; }

      
    }
}
