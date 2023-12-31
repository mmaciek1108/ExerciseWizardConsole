
using ExerciseWizardConsole.Entities;

namespace ExerciseWizardConsole.Repositories
{
    public class QuestionRepository
    {
        private readonly List<Question> _question = new();

        public void Add(Question question)
        {
            question.Id = _question.Count + 1;
            _question.Add(question);
        }
        public void Save()
        {
            foreach (var question in _question)
            {
                Console.WriteLine(question);
            }
        }

        public Question GetById(int id)
        {
            return _question.Single(item => item.Id == id);
        }
    }
}