using Entity_Framework_Sql.Models;
using Entity_Framework_Sql.Services;
using Entity_Framework_Sql.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Sql.Controllers
{
    internal class CityController
    {
        private readonly ICityService _cityService;

        public CityController()
        {
            _cityService = new CityService();  

        }

        public async Task GetAllByCountryId()
        {
             Console.WriteLine("Add Country id");
            int countryId=int.Parse(Console.ReadLine());

            var cities =await _cityService.GetAllByCountryIdAsync(countryId);
            foreach (var item in cities)
            {
                string data = $"Name:{item.Name},Country:{item.Country.Name}";
                Console.WriteLine(data);
            }

        }
        public async Task GetAllAsync()
        {
            var datas = await _cityService.GetAllAsync();
            foreach (var item in datas)
            {
                string data = $"Name: {item.Name} ";
                Console.WriteLine(data);

            }
        }

        public async Task GetByIdAsync()
        {
            Console.WriteLine("Add city id");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                var data = await _cityService.GetByIdAsync(id);



                string result = $"Name: {data.Name} ";

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }

        public async Task DeleteAsync()
        {
            Console.WriteLine("Add city id");
            int id = Convert.ToInt32(Console.ReadLine());

            try
            {
                await _cityService.DeleteAsync(id);


                Console.WriteLine("Data Deleted");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public async Task CreateAsync()
        {
            Console.WriteLine("Add name");
            string name = Console.ReadLine();

            Console.WriteLine("Add CountryId");
            int CountryId = Convert.ToInt32(Console.ReadLine());



            await _cityService.CreateAsync(new City { Name = name, CountryId = CountryId });


        }

    }
}
