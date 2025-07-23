using Notosorus_V2.Model;
using System.Data.Entity; 

public class AppDbContext : DbContext
{
    public DbSet<Semester> Semesters { get; set; }
    public DbSet<Classes> Classes { get; set; }
    public DbSet<Notes> Notes { get; set; }
    public DbSet<Grades> Grades { get; set; }

    public AppDbContext() : base("name=DefaultConnection") 
    {
    }
}

