using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository.RMenu;
using ApexRestaurant.Repository.RMenuItem;
using ApexRestaurant.Repository.RRef_Staff_Role;
using ApexRestaurant.Repository.RMeals;
using ApexRestaurant.Repository.RStaff;
using ApexRestaurant.Repository.RMeal_Dishes;

namespace ApexRestaurant.Repository
{
    public static class RepositoryModule
    {   
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<RestaurantContext>(options =>options.UseNpgsql(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IMenuItemRepository, MenuItemRepository>();
            services.AddTransient<IRef_Staff_RoleRepository, Ref_Staff_RoleRepository>();
            services.AddTransient<IMealsRepository, MealsRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IMeal_DishesRepository, Meal_DishesRepository>();
            
        }
    }
}