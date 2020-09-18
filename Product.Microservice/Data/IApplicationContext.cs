using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Product.Microservice.Data
{
    public interface IApplicationContext
    {
        DbSet<Entities.Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}