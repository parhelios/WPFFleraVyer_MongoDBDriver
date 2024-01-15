using System.Threading.Tasks;
using WPFFleraVyer.Models;

namespace WPFFleraVyer.Managers;

public static class CounterManager
{
     public static CounterModel CounterModel { get; set; } = new CounterModel();

     public static async Task Save()
     {

     }
}