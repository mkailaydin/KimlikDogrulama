using KimlikDogrulama.Abstract;
using KimlikDogrulama.Entities;
using KimlikDogrulama.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikDogrulama.Adapters
{
    /// <summary>
    /// Dogrulama Servisi kullanılmak istenilirse yapıcı metotda bu sınıf kullanılmalıdır.
    /// </summary>
   public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
