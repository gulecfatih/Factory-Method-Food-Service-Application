using Factory_Method_Food_Service_Application.Abstracts;
using Factory_Method_Food_Service_Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Food_Service_Application.Factories
{
    // Soyut fabrika sınıfı
    public abstract class Restaurant
    {
        // Yemek nesnesi oluşturmak için fabrika metodunu tanımlayan soyut metot
        public abstract Meal CreateMeal(MealType type);

        // Verilen yemek türüne göre yemeği hazırlayan ve içerdiği malzemeleri döndüren metot
        public string ServeMeal(MealType type)
        {
            Meal meal = CreateMeal(type); // Fabrika metodunu kullanarak yemek nesnesi oluşturulur
            return "Serving: " + meal.GetIngredients(); // Oluşturulan yemeğin içerdiği malzemeler string olarak döndürülür
        }
    }
}
