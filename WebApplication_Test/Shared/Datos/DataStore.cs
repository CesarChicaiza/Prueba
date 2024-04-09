using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Datos
{
    public static class DataStore
    {
        public static List<Customer> customers = new List<Customer> { 
            new Customer(){ Id=1,Name="JUAN", LastName="PEREZ", IdentificationDocument="1720103225",Email="JPEREZ@GMAIL.COM", Phone="0979287300",RegisterDate=DateTime.Now},
            new Customer(){ Id=2,Name="EDGAR", LastName="SANCHEZ", IdentificationDocument="1720103235",Email="ESANCHEZ@GMAIL.COM", Phone="0979287301",RegisterDate=DateTime.Now},
            new Customer(){ Id=3,Name="ANA", LastName="MENDEZ", IdentificationDocument="1770104245",Email="AMENDEZ@GMAIL.COM", Phone="0987287304",RegisterDate=DateTime.Now}
        };  
    }
}
