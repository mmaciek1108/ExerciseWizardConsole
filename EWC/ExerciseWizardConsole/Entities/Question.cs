
namespace ExerciseWizardConsole.Entities
{
    public class Question : EntityBase
    {
        public string? Content { get; set; }
        public override string ToString() => $" Pytanie nr {Id}: {Content}";
    }
}