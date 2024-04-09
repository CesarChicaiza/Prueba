using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public class PaymentAgreement
    {
        public long Id { get; set; }

        public int PaymentMonth { get; set; } = 0;

        public long PaymentAmount { get; set; } = 0;

        //Fechas
        public DateTime StartDate { get; set; } = DateTime.MinValue;
        public long CustomerId { get; set; }

    }
}
