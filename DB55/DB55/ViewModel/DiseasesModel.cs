using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB55.ViewModel
{
    public class DiseasesModel
    {
       
        

        public int Id { get; set; }
        public string Name { get; set; }
        public int DoctorId { get; set; }
        public int PredictionID { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Lookup Lookup { get; set; }
        
    }
}