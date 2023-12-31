
namespace ExerciseWizardConsole.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public override string ToString() => $"Id: {Id}, Content: {Content}";
    }
}