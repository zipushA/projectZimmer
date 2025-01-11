using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerArcitect.core.Models
{
    public class Owner
    {   [Key]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank_account { get; set; }
        public DateTime Date_registration { get; set; }
        public List<Zimmer> zimmers { get; set; }

        public Owner()
        {

        }
        public Owner(Owner o)
        {
            Id =o.Id;
            Tz = o.Tz;
            Name = o.Name;
            Address = o.Address;
            Phone = o.Phone;
            Bank_account = o.Bank_account;
            Date_registration = o.Date_registration;
        }
        public Owner(int id_from_body, Owner o)
        {
            Id = id_from_body;
            Tz = o.Tz;
            Name = o.Name;
            Address = o.Address;
            Phone = o.Phone;
            Bank_account = o.Bank_account;
            Date_registration = o.Date_registration;
        }
    }
}
