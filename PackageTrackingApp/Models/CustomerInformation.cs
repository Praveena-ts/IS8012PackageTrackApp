using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageTrackingApp.Models
{
    public class CustomerInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public bool? AlreadyCustomer { get; set; }
       
    }
}
