using credabl.shared.Model;
using service.layer.Interface;

namespace customer.service
{
    public class CustomerService : ICustomerservice
    {
        List<Customer> customerData;
        public CustomerService() 
        {
            customerData = new List<Customer>();
            initiateCustomerData();
        }
        
        // This will add a new customer 
        public List<Customer> AddCustomer(Customer customer)
        {
            customerData.Add(customer);
            return customerData;
        }

        public List<Customer> DeleteCustomers(int id)
        {
            var itemToRemove = customerData.Single(r => r.Id == id);
            customerData.Remove(itemToRemove);
            return customerData;
        }

        // Get Customer will list out all customers
        public List<Customer> GetCustomer()
        {
            return customerData;
        }

        public List<Customer> UpdateCustomer(Customer customer)
        {
            var obj = customerData.FirstOrDefault(x => x.Id == customer.Id);
            if (obj != null) obj = customer;
            return customerData;
        }

        public void initiateCustomerData()
        {
            AddCustomer(new Customer { Id = 1, Name = "John", Scheduled = DateTime.Now, Location = "Seattle" });
            AddCustomer(new Customer { Id = 2, Name = "bob", Scheduled = DateTime.Now, Location = "NSW" });
            AddCustomer(new Customer { Id = 3, Name = "Mary", Scheduled = DateTime.Now, Location = "QLD" });
        }
    }
}
