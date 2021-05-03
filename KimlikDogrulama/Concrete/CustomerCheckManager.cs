using KimlikDogrulama.Abstract;
using KimlikDogrulama.Entities;

namespace KimlikDogrulama.Concrete
{
    /// <summary>
    /// Test yapılmak istediğinde yapıcı metotda bu sınıf kullanılmalıdır.
    /// </summary>
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
