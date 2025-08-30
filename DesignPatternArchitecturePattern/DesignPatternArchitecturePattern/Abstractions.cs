using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecturePattern
{
    //Think in terms of abstractions, not implementations.
    interface ICustomer
    {
        string Name { get; set; }
        string Age { get; set; }
        decimal Amount { get; set; }
        decimal CalculateDiscount();
    }

    interface IEnquiry
    {
        string Name { get; set; }
        string Age { get; set; }
    }
    interface IProduct
    {

    }

    interface IDiscount
    {

    }
}
