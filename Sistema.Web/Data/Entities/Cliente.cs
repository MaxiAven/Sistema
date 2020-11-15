using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Data.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Complete el campo {0}")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        [Display(Name = "Razon Social")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "Complete el campo {0}")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Complete el campo {0}")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Complete el campo {0}")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        public string NroDocumento { get; set; }
        [Required(ErrorMessage = "Complete el campo {0}")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Complete el campo {0}")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1}")]
        public string CodigoPostal { get; set; }

        //relaciones
        [ForeignKey("DocumentoId")]
        public Documento Documento { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
        public Localidad Localidad { get; set; }
        public Provincia Provincia { get; set; }


    }
}
