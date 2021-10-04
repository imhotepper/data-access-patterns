
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;

public class AppDB: DbContext{

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=CustomerDB.db;");
    }
    public DbSet<Vehicle> Vehicles { get; set; }
}