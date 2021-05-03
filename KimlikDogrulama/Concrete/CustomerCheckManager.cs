using KimlikDogrulama.Abstract;
using KimlikDogrulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
