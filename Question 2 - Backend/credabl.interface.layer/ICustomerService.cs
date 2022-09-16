using credabl.shared.Model;
using System.Runtime.InteropServices;

namespace service.layer.Interface
{
    public interface ICustomerservice
    {
        List<Customer> GetCustomer();
        List<Customer> AddCustomer(Customer customer);
        List<Customer> UpdateCustomer(Customer customer);
        List<Customer> DeleteCustomers(int id);

    }
}
