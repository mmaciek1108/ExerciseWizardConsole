
namespace ExerciseWizardConsole.Entities
{
    public class MultipleAnswerTests : EntityBase
    {
        public string? MultipleAnswer { get; set; }

        public override string ToString() => $"Test nr: {Id} \n {Content} \n {MultipleAnswer}";
    }
}