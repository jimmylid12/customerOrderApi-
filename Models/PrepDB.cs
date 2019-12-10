using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomersOrderService.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CustomersOrderService.Models
{
    public class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<OrdersContext>());
            }
        }
        public static void SeedData(OrdersContext context)
        {
            System.Console.WriteLine("Applying Migrations...");

            context.Database.Migrate();
        }
    }
}
