using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmerArcitect.core.Models
{
    public class Cleaner
    {
       [Key]
        public int Id { get;  set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank_account { get; set; }
        public DateTime Date_registration { get; set; }
        public int Total_for_an_hour_of_work { get; set; }
        public int Total_salary { get; set; }
        public int Total_working_hours { get; set; }
        public List<Zimmer> Zimmers { get; set; }
        public Cleaner()
        {

        }
        public Cleaner(Cleaner c)
        {
            Id = c.Id;
            Tz = c.Tz;
            Name = c.Name;
            Address = c.Address;
            Phone = c.Phone;
            Bank_account = c.Bank_account;
            Date_registration = c.Date_registration;
            Total_for_an_hour_of_work = c.Total_for_an_hour_of_work;
            Total_salary = c.Total_salary;
            Total_working_hours = c.Total_working_hours;
        }
        public Cleaner(int id_from_body, Cleaner c)
        {
            Id = id_from_body;
            Tz = c.Tz;
            Name = c.Name;
            Address = c.Address;
            Phone = c.Phone;
            Bank_account = c.Bank_account;
            Date_registration = c.Date_registration;
            Total_for_an_hour_of_work = c.Total_for_an_hour_of_work;
            Total_salary = c.Total_salary;
            Total_working_hours = c.Total_working_hours;
        }
    }
}
