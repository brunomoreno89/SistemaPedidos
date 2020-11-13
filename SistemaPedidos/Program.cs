﻿using System;
using SistemaPedidos.Entities;
using SistemaPedidos.Entities.Emuns;


namespace SistemaPedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);



        }
    }
}
