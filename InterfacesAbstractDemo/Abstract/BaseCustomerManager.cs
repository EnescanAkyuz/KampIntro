using InterfacesAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerservice
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to database : "+customer.Name);
        }
    }
}
