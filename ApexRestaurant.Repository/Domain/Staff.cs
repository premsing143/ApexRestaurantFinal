using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Staff
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