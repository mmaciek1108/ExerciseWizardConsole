
namespace ExerciseWizardConsole.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public string? Content { get; set; }
    }
}