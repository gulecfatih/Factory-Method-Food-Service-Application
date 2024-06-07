using Factory_Method_Food_Service_Application.Enum;
using Factory_Method_Food_Service_Application.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Food_Service_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new CustomRestaurant(); // Özelleştirilmiş restoran nesnesi oluşturulur

            // Pizza ve burger servisi yapılır
            Console.WriteLine(restaurant.ServeMeal(MealType.Pizza));
            Console.WriteLine(restaurant.ServeMeal(MealType.Burger));
        }
    }
}
