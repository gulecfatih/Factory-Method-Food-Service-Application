using Factory_Method_Food_Service_Application.Abstracts;
using Factory_Method_Food_Service_Application.Enum;
using Factory_Method_Food_Service_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Food_Service_Application.Factories
{
    // Özelleştirilmiş restoran sınıfı, Restaurant sınıfından türetilmiştir
    public class CustomRestaurant : Restaurant
    {
        // Yemek türüne göre uygun yemek nesnesini oluşturan metot
        public override Meal CreateMeal(MealType type)
        {
            switch (type)
            {
                case MealType.Pizza:
                    return new Pizza(); // Pizza nesnesi oluşturulur
                case MealType.Burger:
                    return new Burger(); // Burger nesnesi oluşturulur
                default:
                    throw new ArgumentException("Unknown meal type"); // Bilinmeyen yemek türü hatası fırlatılır
            }
        }
    }
}
