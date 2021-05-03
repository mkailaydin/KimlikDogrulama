using KimlikDogrulama.Entities;
using System;

namespace KimlikDogrulama.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName);

            Console.ReadLine();
        }
    }
}
