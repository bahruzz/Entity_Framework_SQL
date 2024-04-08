using Entity_Framework_Sql.Data;
using Entity_Framework_Sql.Helpers.Exceptions;
using Entity_Framework_Sql.Models;
using Entity_Framework_Sql.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Sql.Services
{
    internal class CityService : ICityService
    {
        private readonly AppDbContext _context;
        public CityService()
        {
            _context = new AppDbContext(); 
        }

        public async Task CreateAsync(City city)
        {
            await _context.Cities.AddAsync(city);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {

            var data = _context.Cities.FirstOrDefault(x => x.Id == id);
            if (data is null)
            {
                throw new NotFoundException("Data not found");
            }
            _context.Cities.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<List<City>> GetAllByCountryIdAsync(int id)
        {
           return await _context.Cities.Include(m=>m.Country).Where(m=>m.CountryId==id).ToListAsync();  
            
        }

        public async Task<City> GetByIdAsync(int id)
        {
            var data = _context.Cities.FirstOrDefault(x => x.Id == id);
            if (data is null)
            {
                throw new NotFoundException("Data not found");
            }
            return data;
        }
    }
}
