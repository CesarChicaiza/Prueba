using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dto
{
    public class CustomerDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("lastName")]
        public string LastName { get; set; } = string.Empty;

        [JsonProperty("email")]
        public string Email { get; set; } = string.Empty;

        [JsonProperty("phone")]
        public string Phone { get; set; } = string.Empty;
        [JsonProperty("identification")]
        public string IdentificationDocument { get; set; } = string.Empty;

        //Fechas
        [JsonProperty("registerDate")]
        public DateTime RegisterDate { get; set; } = DateTime.MinValue;

        //elements
        [JsonProperty("paymentAgreements")]
        public List<PaymentAgreementDto>? PaymentAgreementDtos { get; set; }
    }
}
