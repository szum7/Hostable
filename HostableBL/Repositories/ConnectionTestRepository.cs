using HostableBL.Interfaces;
using HostableDAL;
using HostableDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HostableBL.Repositories
{
    public class ConnectionTestRepository : IConnectionTest
    {
        public int GetNumber()
        {
            using (DBContext context = new DBContext())
            {
                return 123;
            }
        }

        public List<ConnectionTest> Get()
        {
            using (DBContext context = new DBContext())
            {
                return (from c in context.ConnectionTest
                        select new ConnectionTest()
                        {
                            Id = c.Id,
                            Category = c.Category,
                            Name = c.Name
                        }).ToList();
            }
        }
    }
}
