using Microsoft.EntityFrameworkCore;
using VehicleManage.Models;

namespace VehicleManage.Data{
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
        {

        }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Vehicle> Vehicles { get; set; }
}

}
