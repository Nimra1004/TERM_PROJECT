using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB55.Models
{
    public class DiseaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DoctorId { get; set; }
        public int PredictionID { get; set; }
        public int CategoryId { get; set; }

    }
}