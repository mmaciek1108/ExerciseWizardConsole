
using ExerciseWizardConsole.Repositories;
using ExerciseWizardConsole.Entities;
using ExerciseWizardConsole.Data;

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

var sqlRepo = new SqlRepository<Question>(new EwcDBContext());
sqlRepo.Add(new Question { Content = "Kto dostał nagrobę Nobla w 1921r.?" });
sqlRepo.Add(new Question { Content = "Za co dostał nagrodę Noba Max Planck?" });
sqlRepo.Save();

var qus = sqlRepo.GetById(2);
Console.WriteLine(qus.ToString());