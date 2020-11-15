using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Data.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        //Relaciones
        public Pedido Pedido { get; set; }
        public ICollection<TipoProducto> TipoProductos { get; set; }
    }
}
