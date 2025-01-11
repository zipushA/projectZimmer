using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerArcitect.core.Models
{
    public class Order
    {   [Key]
        public int Id { get;  set; }
        public int User_id { get; set; }
        public int Zimmer_id { get; set; }
        public DateTime Starting_date { get; set; }
        public int Num_of_nights { get; set; }
        public int Total_sum { get; set; }
        public Order()
        {

        }
        public Order(Order o)
        {
            Id =o.Id;
            User_id = o.User_id;
            Zimmer_id = o.Zimmer_id;
            Starting_date = o.Starting_date;
            Num_of_nights = o.Num_of_nights;
            Total_sum = o.Total_sum;
        }
        public Order(int id_from_body, Order o)
        {
            Id = id_from_body;
            User_id = o.User_id;
            Zimmer_id = o.Zimmer_id;
            Starting_date = o.Starting_date;
            Num_of_nights = o.Num_of_nights;
            Total_sum = o.Total_sum;
        }
    }
}
