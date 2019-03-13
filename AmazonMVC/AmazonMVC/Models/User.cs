using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AmazonMVC.Models
{
    public class User
    {
        private string uFirstName;
        private string uLastName;
        private string uAge;
        
        [DisplayName("First Name")]
        public string UFirstName { get => uFirstName; set => uFirstName = value; }
        [DisplayName("Last Name")]
        public string ULastName { get => uLastName; set => uLastName = value; }
        [DisplayName("Age")]
        public string UAge { get => uAge; set => uAge = value; }
    }
}