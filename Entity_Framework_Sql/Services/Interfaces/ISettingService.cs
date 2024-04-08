using Entity_Framework_Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Sql.Services.Interfaces
{
    internal interface ISettingService
    {
        Task<List<Setting>> GetAllAsync();
        Task<Setting> GetByIdAsync(int id);  
        Task CreateAsync(Setting setting);
        Task UpdateAsync(Setting setting,int id);
        Task DeleteAsync(int id);
    }
}
