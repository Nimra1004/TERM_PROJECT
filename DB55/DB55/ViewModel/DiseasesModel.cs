using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DB55.ViewModel
{
    public class DiseasesModel
    {
        
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int DoctorId { get; set; }
        public int PredictionID { get; set; }
        public int CategoryId { get; set; }

        public static IEnumerable<SelectListItem> GetPredictionId()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new  SelectListItem{Text = "Disease", Value = "1" },
                new  SelectListItem{Text = "Condition", Value = "2" },
            };
            return items;
        }
    }
}