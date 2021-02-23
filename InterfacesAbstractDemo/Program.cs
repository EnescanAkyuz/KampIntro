using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Concrete;
using System;

namespace InterfacesAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(2002, 8, 15), Name = "Enescan", LastName = "Akyüz", NationalityId = "50758821860" });


        }
    }
}
