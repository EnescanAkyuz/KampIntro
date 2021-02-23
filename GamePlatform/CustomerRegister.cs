using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    abstract class CustomerRegister : ISaveServices
    {

        void ISaveServices.Save(Customer customer)
        {
            Console.WriteLine(customer.Nickname+ "adlı kullanıcı kaydı alındı.");
        }
    }
}
