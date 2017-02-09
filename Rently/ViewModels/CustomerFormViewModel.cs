using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rently.Models;

namespace Rently.ViewModels
{
    public class CustomerFormViewModel
    {
        //get the list of membership type and we iterate with IEnumerable
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        //we get the customer enitity
        public Customer Customer { get; set; }
    }
}