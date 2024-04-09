using Newtonsoft.Json;
using Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public class Customer
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; } 

        public string? Phone { get; set; }
        public string? IdentificationDocument { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.MinValue;

        public List<PaymentAgreement>? PaymentAgreements{ get; set; }
    }
}
