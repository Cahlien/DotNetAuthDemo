using DotNetAuthDemo.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetAuthDemo.Data;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<DemoUser>(options)
{
    public DbSet<DemoUser> DemoUsers { get; set; }
}