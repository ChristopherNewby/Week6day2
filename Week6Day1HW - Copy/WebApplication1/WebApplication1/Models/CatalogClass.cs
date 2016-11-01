using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CatalogClass
    {
        [DisplayName("Movie Name")]
        public Movie newMov { get; set; }

        [DisplayName("Customer")]
        public Customer newCust { get; set; }

        [DisplayName("Return Date")]
        public RentalRecord newRecord { get; set; }

        

    }
}