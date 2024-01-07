
namespace ExerciseWizardConsole.Entities
{
    public class MultipleAnswerTest : Question
    {
        public string? Answer1 { get; set; }
        public string? Answer2 { get; set; }
        public string? Answer3 { get; set; }
        public string? Answer4 { get; set; }

        public override string ToString() => $"Pytnie testowe nr: {Id} \n {Content} \n A.{Answer1} \n B.{Answer2} \n C.{Answer3} \n D.{Answer4}";
    }
}