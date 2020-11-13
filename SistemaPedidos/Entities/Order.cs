using System;
using System.Collections.Generic;
using System.Text;
using SistemaPedidos.Entities.Emuns;
using System.Globalization;

namespace SistemaPedidos.Entities
{
    // Class to orders
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }

    
}
