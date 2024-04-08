
//using Entity_Framework_Sql.Data;

//AppDbContext context = new AppDbContext();  
//void GetAllSettings()
//{
//    var datas= context.Settings.ToList();
//    foreach (var item in datas)
//    {
//        Console.WriteLine(item.Address+ " " + item.Phone + " " + item.Email+ " " +item.Name);
//    }
//}

//void GetById(int id)
//{
//    var data = context.Settings.FirstOrDefault(m => m.Id == id);
//    Console.WriteLine(data.Address+ " " +data.Phone+ " "    +data.Email+ " " +data.Name);
//}

//GetAllSettings();

//Console.WriteLine("-----------------------------");

//GetById(3);

using Entity_Framework_Sql.Controllers;
using Entity_Framework_Sql.Models;

SettingController settingController = new SettingController();

//await settingController.GetAllAsync();

//await settingController.GetByIdAsync();

//await settingController.CreateAsync();

//await settingController.GetAllAsync();

//await settingController.DeleteAsync();

CityController cityController = new CityController();

//await cityController.GetAllByCountryId();

//await cityController.GetAllAsync();

//await cityController.GetByIdAsync();
//await cityController.DeleteAsync();

await cityController.CreateAsync();
await cityController.GetAllAsync();