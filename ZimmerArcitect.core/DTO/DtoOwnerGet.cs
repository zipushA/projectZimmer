using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.core.DTO
{
    public class DtoOwnerGet
    {
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
