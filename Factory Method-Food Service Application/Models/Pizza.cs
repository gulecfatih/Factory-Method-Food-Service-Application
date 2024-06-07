using Factory_Method_Food_Service_Application.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Food_Service_Application.Models
{
    // Pizza sınıfı
    public class Pizza : Meal
    {
        public override string GetIngredients()
        {
            return "Pizza ingredients";
        }
    }

}
