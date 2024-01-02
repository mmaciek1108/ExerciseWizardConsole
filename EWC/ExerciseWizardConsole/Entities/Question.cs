
namespace ExerciseWizardConsole.Entities
{
    public class Question : EntityBase
    {
        public override string ToString() => $" Pytanie nr {Id}: {Content}";
    }
}