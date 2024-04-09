using Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Interfaces
{
    public interface ICustomerService
    {
        string Create(CustomerDto customerData);
        IEnumerable<CustomerDto> Get();

    }
}
