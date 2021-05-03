using KimlikDogrulama.Abstract;
using KimlikDogrulama.Entities;
using System;

namespace KimlikDogrulama.Concrete
{

    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer) == true)
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Dogrulama Basarisiz");
            }
        }
    }
}
