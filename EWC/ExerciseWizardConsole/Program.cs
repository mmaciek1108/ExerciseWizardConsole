
using ExerciseWizardConsole.Repositories;
using ExerciseWizardConsole.Entities;

var questionRepository = new GenericRepository<Question>();

var questionRepositoryTest = new GenericRepository<MultipleAnswerTests>();

questionRepository.Add(new Question { Content = "Jak na imię miał Napoleon?" });
questionRepository.Save();

questionRepositoryTest.Add(new MultipleAnswerTests
{
    Content = "Pytanie testowe",
    MultipleAnswer = "NowaWartosc"
});
questionRepositoryTest.Save();