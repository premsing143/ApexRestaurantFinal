using System;

namespace ApexRestaurant.Mvc.Models
{
    public class StaffViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneMob { get; set; }

        public bool IsActive { get; set; }

        public string UpdatedBy { get; set; }

    }
}