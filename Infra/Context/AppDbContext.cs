using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context;

public class AppDbContext : DbContext
{
    public DbSet<Item> Item { get; set; }
    public DbSet<User> User { get; set; }
}

