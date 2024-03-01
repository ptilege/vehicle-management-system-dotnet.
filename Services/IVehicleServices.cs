using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleManage.Models; // Add this using directive

public interface IVehicleService
{
    Task<Vehicle> CreateVehicleAsync(Vehicle vehicle);
    Task<Vehicle?> GetVehicleByIdAsync(int id);
    Task<IEnumerable<Vehicle>> GetVehiclesAsync();
    Task UpdateVehicleAsync(Vehicle vehicle);
    Task DeleteVehicleAsync(int id);
}
