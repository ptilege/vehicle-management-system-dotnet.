using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleManage.Models; 
using VehicleManage.Data;

namespace VehicleManage.Services
{
public class VehicleService : IVehicleService
{
    private readonly ApplicationDbContext _context;

    public VehicleService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Vehicle> CreateVehicleAsync(Vehicle vehicle)
    {
        _context.Vehicles.Add(vehicle);
        await _context.SaveChangesAsync();
        return vehicle;
    }

    public async Task<Vehicle?> GetVehicleByIdAsync(int id)
    {
        return await _context.Vehicles.FindAsync(id);
    }

    public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
    {
        return await _context.Vehicles.ToListAsync();
    }

    public async Task UpdateVehicleAsync(Vehicle vehicle)
    {
        _context.Entry(vehicle).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteVehicleAsync(int id)
    {
        var vehicleToDelete = await _context.Vehicles.FindAsync(id);
        if (vehicleToDelete != null)
        {
            _context.Vehicles.Remove(vehicleToDelete);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("Vehicle not found");
        }
    }
}
}
