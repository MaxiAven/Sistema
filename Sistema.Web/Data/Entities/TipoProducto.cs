using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Data.Entities
{
    public class TipoProducto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Complete el campo {0}")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        public string Descripcion { get; set; }

        //Relaciones
        public TipoProducto TipoProductos { get; set; }
    }

}
