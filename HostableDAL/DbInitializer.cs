using HostableDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HostableDAL
{
    public static class DbInitializer
    {
        public static void Initialize(DBContext context)
        {
            context.Database.EnsureCreated();

            if (context.ConnectionTest.Any())
            {
                return;
            }

            var data = new ConnectionTest[]
            {
                new ConnectionTest(){ Name = "A", Category = "B" },
                new ConnectionTest(){ Name = "C", Category = "D" }
            };

            foreach (var item in data)
            {
                context.ConnectionTest.Add(item);
            }
            context.SaveChanges();
        }
    }
}
