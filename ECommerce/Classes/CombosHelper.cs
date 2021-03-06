using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();
        public static List<Departaments> GetDepartaments() {
        
        var dep = db.Departaments.ToList();
        dep.Add(new Departaments
            {
                DepartamentsId = 0,
                Name = "[ Selecione um Departamento ]"
            }) ;

            return dep = dep.OrderBy(d => d.Name).ToList();

}


        public static List<City> GetCities()
        {

            var dep = db.Cities.ToList();
            dep.Add(new City  
            {
                DepartamentsId = 0,
                Name = "[ Selecione um Cidade ]"
            });

            return dep = dep.OrderBy(d => d.Name).ToList();

        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}