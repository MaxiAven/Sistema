using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Data.Entities
{
    public class DetallePedido
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Complete el campo {0}")]
        public int Cantidad { get; set; }

        //Relaciones
        public Pedido Pedidos { get; set; }
    }
}
