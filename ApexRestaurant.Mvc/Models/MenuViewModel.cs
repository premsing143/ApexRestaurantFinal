using System;

namespace ApexRestaurant.Mvc.Models
{
    public class MenuViewModel
    {
        public int Id { get; set; }

        public string MenuItem { get; set; }
        
        public DateTime Available_Date_Form { get; set; }

        public bool IsActive { get; set; }

        public string Available_Date_to { get; set; }

        public String MenuType { get; set; }

    }
}