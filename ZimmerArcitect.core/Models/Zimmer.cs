using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerArcitect.core.Models
{
    public class Zimmer
    {
        [Key]
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Num_of_rooms { get; set; }
        public int Num_of_beds { get; set; }
        public bool Yard_and_pool { get; set; }
        public int Total_per_night { get; set; }
        public int Num_of_nights_rented { get; set; }
        public int OwnerId {  get; set; }
        public int CleanerId { get; set; }

        public Owner owner { get; set; }
        public Cleaner cleaner { get; set; }
        public Zimmer()
        {

        }
        public Zimmer(Zimmer z)
        {
            Id = z.Id;
            Name = z.Name;
            Address = z.Address;
            Num_of_rooms = z.Num_of_rooms;
            Num_of_beds = z.Num_of_beds;
            Yard_and_pool = z.Yard_and_pool;
            Total_per_night = z.Total_per_night;
            Num_of_nights_rented = z.Num_of_nights_rented;
        }
        public Zimmer(int id_from_body, Zimmer z)
        {
            Id = id_from_body;
            Name = z.Name;
            Address = z.Address;
            Num_of_rooms = z.Num_of_rooms;
            Num_of_beds = z.Num_of_beds;
            Yard_and_pool = z.Yard_and_pool;
            Total_per_night = z.Total_per_night;
            Num_of_nights_rented = z.Num_of_nights_rented;
        }
    }
}
