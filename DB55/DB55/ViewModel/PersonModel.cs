using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB55.ViewModel
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public int Discriminator { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual DoctorModel Doctor { get; set; }
        public virtual Lookup Lookup { get; set; }
        public virtual Lookup Lookup1 { get; set; }
    }
}