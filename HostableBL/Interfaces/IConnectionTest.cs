using HostableDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HostableBL.Interfaces
{
    public interface IConnectionTest
    {
        List<ConnectionTest> Get();
        int GetNumber();
    }
}
