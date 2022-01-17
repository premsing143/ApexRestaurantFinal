 using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMeals;
using ApexRestaurant.Services.SMenu;
using ApexRestaurant.Services.SMenuItem;
using ApexRestaurant.Services.SStaff;
using ApexRestaurant.Services.SRef_Staff_Role;
using ApexRestaurant.Services.SMeal_Dishes;

namespace ApexRestaurant.Services
{  
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMealsService, MealsService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IMenuItemService, MenuItemService>();
            services.AddTransient<IStaffService, StaffService>();
            services.AddTransient<IRef_Staff_RoleService, Ref_Staff_RoleService>();
            services.AddTransient<IMeal_DishesService, Meal_DishesService>();
        }

    }                                                                                                                                                                                                                                                                                                                                                                    
}