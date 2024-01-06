
namespace ExerciseWizardConsole.Entities
{
    public class MultipleAnswerTests : Question
    {
        public string? MultipleAnswer { get; set; }

        public override string ToString() => $"Pytnie testowe nr: {Id} \n {Content} \n {MultipleAnswer}";
    }
}