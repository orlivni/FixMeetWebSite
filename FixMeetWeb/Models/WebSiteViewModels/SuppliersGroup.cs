using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FixMeetWeb.Models.WebSiteViewModels
{
    public class SuppliersGroup
    {
        [DataType(DataType.Date)]
        public DateTime? JoinDate { get; set; }

        public int SupplierCount { get; set; }
    }
}
