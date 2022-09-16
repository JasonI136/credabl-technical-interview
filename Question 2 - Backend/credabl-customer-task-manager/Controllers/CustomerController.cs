using credabl.shared.Model;
using Microsoft.AspNetCore.Mvc;
using service.layer.Interface;

namespace credabl_customer_task_manager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        ICustomerservice _icustcs;
        
        public CustomerController(ICustomerservice icust) 
        {
            _icustcs = icust;
        }

        [HttpGet]
        public List<Customer> GetCustomers() 
        {
            return _icustcs.GetCustomer();
        }

        [HttpDelete]
        public List<Customer> DeleteCustomer(int id)
        {
            return _icustcs.DeleteCustomers(id);
        }

        [HttpPost]
        public List<Customer> AddCustomer(Customer customer)
        {
            return _icustcs.AddCustomer(customer);
        }

        [HttpPost]
        public List<Customer> UpdateCustomer(Customer customer)
        {
            return _icustcs.UpdateCustomer(customer);
        }

    }
}
