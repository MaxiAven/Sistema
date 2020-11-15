using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Data.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        //relciones
        public Cliente Clientes { get; set; }
        public ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
