using BussinesLogic.Interfaces;
using Shared.Datos;
using Shared.Dto;
using Shared.Mapper;

namespace BussinesLogic.CustomerService
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {

        }
        public string Create(CustomerDto customerData)
        {
            long id = DataStore.customers.LastOrDefault()?.Id ?? 0;
            customerData.Id= id+1;
            var customer = CustomerMap.MapCustome(customerData);
            DataStore.customers.Add(customer);
            return "Ingreso exitoso";
        }


        public IEnumerable<CustomerDto> Get()
        {
            var customers = DataStore.customers;
            return customers.Select(x=>CustomerMap.MapCustomeDto(x));
        }
    }
}
