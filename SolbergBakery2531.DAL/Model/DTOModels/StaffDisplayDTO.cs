using SolbergBakery2531.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolbergBakery2531.DAL.DTOModels
{
    public class StaffDisplayDTO
    {
        public Staff Staff { get; set; }
        public DateTime? LastHistoryStart { get; set; }
    }
}
