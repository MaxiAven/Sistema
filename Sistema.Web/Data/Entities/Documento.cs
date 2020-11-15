using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Data.Entities
{
    public class Documento
    {
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        public string Descripcion { get; set; }

        //relacion
        public ICollection<Cliente> Cliente { get; set; }
    }
}
