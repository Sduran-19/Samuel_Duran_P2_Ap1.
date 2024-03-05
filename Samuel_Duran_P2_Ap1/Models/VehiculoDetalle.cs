using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuel_Duran_P2_Ap1.Models
{
    public class VehiculoDetalle
    {
        [Key]
        public int Id { get; set; }

        public int VehiculoId { get; set; }

        public int AccesorioId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public int? Valor {  get; set; }


        public VehiculoDetalle() { }

        public VehiculoDetalle(int Id, int AccesorrioId, string Descripcion)
        {
            Id = Id;
            AccesorrioId = AccesorrioId;
            Descripcion = Descripcion;
        }

    }
}
