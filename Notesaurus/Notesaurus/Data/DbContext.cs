using Microsoft.EntityFrameworkCore;
using Notesaurus.Model;

public class AppDbContext : DbContext
{
    public DbSet<Semester> Semesters { get; set; }
    public DbSet<Classes> Classes { get; set; }
    public DbSet<Notes> NoteS { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Notesaurus.db");
    }
}
