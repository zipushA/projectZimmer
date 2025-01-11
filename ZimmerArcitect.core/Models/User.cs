using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerArcitect.core.Models
{
    public class User
    {   [Key]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank_account { get; set; }
        public DateTime Date_registration { get; set; }
        public int Max_amount_per_night { get; set; }
        public int Num_of_persons { get; set; }
        public int Num_of_orders { get; set; }
        public User()
        {

        }
        public User(User u)
        {
            Id = Id;
            this.Tz = u.Tz;
            this.Name = u.Name;
            this.Address = u.Address;
            this.Phone = u.Phone;
            this.Bank_account = u.Bank_account;
            this.Date_registration = u.Date_registration;
            this.Max_amount_per_night = u.Max_amount_per_night;
            this.Num_of_persons = u.Num_of_persons;
            this.Num_of_orders = u.Num_of_orders;
        }
        public User(int id_from_body, User u)
        {
            Id = id_from_body;
            this.Tz = u.Tz;
            this.Name = u.Name;
            this.Address = u.Address;
            this.Phone = u.Phone;
            this.Bank_account = u.Bank_account;
            this.Date_registration = u.Date_registration;
            this.Max_amount_per_night = u.Max_amount_per_night;
            this.Num_of_persons = u.Num_of_persons;
            this.Num_of_orders = u.Num_of_orders;
        }
        public User(string tz, string name, string address, string phone,
            string bank_account, DateTime date_registration, int max_amount_per_night,
            int num_of_persons, int num_of_orders)
        {
            Id =Id;
            this.Tz = tz;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Bank_account = bank_account;
            this.Date_registration = date_registration;
            this.Max_amount_per_night = max_amount_per_night;
            this.Num_of_persons = num_of_persons;
            this.Num_of_orders = num_of_orders;
        }
    }
}
