
using ExerciseWizardConsole.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExerciseWizardConsole.Data
{
    public class EwcDBContext : DbContext
    {
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<MultipleAnswerTest> MultipleAnswerTest => Set<MultipleAnswerTest>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageEwcDb");
        }
    }
}