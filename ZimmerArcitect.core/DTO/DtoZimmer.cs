﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerArcitect.core.DTO
{
    public class DtoZimmer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Num_of_rooms { get; set; }
        public int Num_of_beds { get; set; }
        public bool Yard_and_pool { get; set; }
        public int Total_per_night { get; set; }
        public int Num_of_nights_rented { get; set; }
        public int OwnerId { get; set; }
        public int CleanerId { get; set; }
    }
}
