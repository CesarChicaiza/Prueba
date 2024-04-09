using Shared.Dto;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Mapper
{
    public static class CustomerMap
    {
        public static CustomerDto MapCustomeDto(Customer x) 
        {
            return new CustomerDto
            {
                Id = x.Id,
                Name = x.Name,
                LastName = x.LastName,
                Email = x.Email,
                IdentificationDocument = x.IdentificationDocument,
                Phone = x.Phone,
                RegisterDate = x.RegisterDate,
                PaymentAgreementDtos = x.PaymentAgreements?.Select(x => MapPaymentDto(x)).ToList()
            };
        }
        public static PaymentAgreementDto MapPaymentDto(PaymentAgreement x) 
        {
            return new PaymentAgreementDto 
            {
                Id = x.Id,
                PaymentAmount= x.PaymentAmount,
                PaymentMonth= x.PaymentMonth,
                StartDate= x.StartDate
            };
        }

        public static Customer MapCustome(CustomerDto x)
        {
            return new Customer
            {
                Id = x.Id,
                Name = x.Name,
                LastName = x.LastName,
                Email = x.Email,
                IdentificationDocument = x.IdentificationDocument,
                Phone = x.Phone,
                RegisterDate = x.RegisterDate
            };
        }
        public static PaymentAgreement MapPayment(PaymentAgreementDto x)
        {
            return new PaymentAgreement
            {
                Id = x.Id,
                PaymentAmount = x.PaymentAmount,
                PaymentMonth = x.PaymentMonth,
                StartDate = x.StartDate
            };
        }
    }
}
