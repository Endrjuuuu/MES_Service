using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MES_Service.Models
{
    public class SearchHistory
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string ModuleName1 { get; set; }
        public string ModuleName2 { get; set; }
        public string ModuleName3 { get; set; }
        public string ModuleName4 { get; set; }
        public decimal ProductionCost { get; set; }
    }
}