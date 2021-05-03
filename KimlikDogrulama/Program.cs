using KimlikDogrulama.Abstract;
using KimlikDogrulama.Adapters;
using KimlikDogrulama.Concrete;
using KimlikDogrulama.Entities;
using System;

namespace KimlikDogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Customer { Id = 1, FirstName = "Adiniz".ToUpperInvariant(), LastName = "Soyadiniz".ToUpper(), DateOfBirth = new DateTime(9999, 1, 1), NationalityId = "11111111111" });

        }
    }
}
