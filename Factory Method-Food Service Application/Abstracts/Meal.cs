using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Food_Service_Application.Abstracts
{
    // Yemek nesnelerinin soyut sınıfı
    public abstract class Meal
    {
        // Yemek içerisindeki malzemelerin alınmasını sağlayan soyut metot
        public abstract string GetIngredients();
    }
}
