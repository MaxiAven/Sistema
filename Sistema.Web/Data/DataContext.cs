using Microsoft.EntityFrameworkCore;
using Sistema.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Data
{
    public class DataContext : DbContext
    {
        //inyeccion a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        //Entities a mapear en la base de datos
        public DbSet<Cliente> Clientes { get; set; }


        //Entities a mapear en la base de datos
        public DbSet<Sistema.Web.Data.Entities.Provincia> Provincia { get; set; }


        //Entities a mapear en la base de datos
        public DbSet<Sistema.Web.Data.Entities.Localidad> Localidad { get; set; }


        //Entities a mapear en la base de datos
        public DbSet<Sistema.Web.Data.Entities.Documento> Documento { get; set; }


        //Entities a mapear en la base de datos
        public DbSet<Sistema.Web.Data.Entities.TipoProducto> TipoProducto { get; set; }
    }
}
