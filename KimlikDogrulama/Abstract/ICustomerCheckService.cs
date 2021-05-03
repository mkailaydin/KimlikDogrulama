using KimlikDogrulama.Entities;

namespace KimlikDogrulama.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
