using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dto
{
    public class PaymentAgreementDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ndt1")]
        public int PaymentMonth { get; set; } = 0;

        [JsonProperty("ndt2")]
        public long PaymentAmount { get; set; } = 0;

        //Fechas
        [JsonProperty("ddt1")]
        public DateTime StartDate { get; set; } = DateTime.MinValue;
    }
}
