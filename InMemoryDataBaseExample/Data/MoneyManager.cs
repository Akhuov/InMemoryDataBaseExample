using InMemoryDataBaseExample.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryDataBaseExample.Data
{
    internal class MoneyManager : DbContext
    {

        public DbSet<InCome> Incomes { get; set; }
        public DbSet<OutCome> OutComes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
