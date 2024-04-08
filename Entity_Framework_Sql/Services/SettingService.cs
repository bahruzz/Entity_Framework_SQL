using Entity_Framework_Sql.Data;
using Entity_Framework_Sql.Helpers.Exceptions;
using Entity_Framework_Sql.Models;
using Entity_Framework_Sql.Services.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Entity_Framework_Sql.Services
{
    internal class SettingService : ISettingService
    {
        private readonly AppDbContext _context;

        public SettingService()
        {
            _context = new AppDbContext();
        }
        public async Task CreateAsync(Setting setting)
        {
           await _context.Settings.AddAsync(setting);   
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {

            var data = _context.Settings.FirstOrDefault(x => x.Id == id);
            if (data is null)
            {
                throw new NotFoundException("Data not found");
            }
           _context.Settings.Remove(data);
            await _context.SaveChangesAsync();

        }

        public async Task<List<Setting>> GetAllAsync()
        {
            return await _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            var data = _context.Settings.FirstOrDefault(x => x.Id == id);
                if (data is null)
            {
                throw new NotFoundException("Data not found");
            }
                return data;

        }

        public async Task UpdateAsync(Setting setting,int id)
        {
            Setting setting1 = await _context.Settings.FirstOrDefaultAsync(m => m.Id == id);

            
            
        }
    }
}
