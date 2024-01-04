
using ExerciseWizardConsole.Repositories;
using ExerciseWizardConsole.Entities;
using ExerciseWizardConsole.Data;
using Microsoft.VisualBasic;

// var questionRepository = new GenericRepository<Question>();

// var questionRepositoryTest = new GenericRepository<MultipleAnswerTests>();

// questionRepository.Add(new Question { Content = "Jak na imię miał Napoleon?" });
// questionRepository.Save();

// questionRepositoryTest.Add(new MultipleAnswerTests
// {
//     Content = "Pytanie testowe",
//     MultipleAnswer = "NowaWartosc"
// });
// questionRepositoryTest.Save();

var questionRepo = new SqlRepository<Question>(new EwcDBContext());
questionRepo.Add(new Question { Content = "Za co dostał nagrodę Noba Max Planck?" });
questionRepo.Add(new Question { Content = "Kto dostał nagrobę Nobla w 1921r.?" });
questionRepo.Save();

GetQuestById(questionRepo);

static void GetQuestById(IRepository<Question> questionRepo)
{
    var question = questionRepo.GetById(2);
    Console.WriteLine(question.ToString());
}