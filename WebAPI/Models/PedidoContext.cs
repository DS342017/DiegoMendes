using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPI.Models
{
    public class PedidoContext : DbContext
    {
        public System.Data.Entity.DbSet<WebAPI.Models.Pedido> Pedidoes { get; set; }
    }
}