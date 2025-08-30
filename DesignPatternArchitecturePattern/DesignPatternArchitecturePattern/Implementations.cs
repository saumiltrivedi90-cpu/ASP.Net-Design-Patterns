using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternArchitecturePattern
{
    public class NormalCustomer : ICustomer
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


Video info

Reload video

        public decimal CalculateDiscount()
        {
            if(IsAmountValid())
            {
                //Business Logic
                return Amount * 0.10M;
            }
            return 0;
        }

        //When the abstraction is created, developer might not no about this method
        //So, Encapsulation comes into picture : To respect abstraction.
        //Declare the method as private to hiding the complexity from the user of the class.
        private bool IsAmountValid()
        {
            if(Amount > 0)
            {
                return true;
            }
            return false;
        }
    }

    public class CustomerAgeType : ICustomer
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }


    //Wrong Abstraction : EnquiryCustomer is not buying anything. So, we should not have Amount Property & CalculateDiscount method here.
    // This is known as LISKOV SUBSTITUTION PRINCIPLE VIOLATION
   /* public class EnquiryCustomer: ICustomer
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    } */
}
