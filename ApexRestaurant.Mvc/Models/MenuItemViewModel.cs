using System;

namespace ApexRestaurant.Mvc.Models
{
    public class MenuItemViewModels
    {
        public int Id { get; set; }

        public String Menu_Item_Title { get; set; }
        
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        
    }
}