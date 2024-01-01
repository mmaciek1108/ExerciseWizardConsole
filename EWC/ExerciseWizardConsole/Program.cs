
using ExerciseWizardConsole.Repositories;
using ExerciseWizardConsole.Entities;

var questionRepository = new GenericRepository<Question>();

questionRepository.Add(new Question { Content = "Jak na imię miał Napoleon?" });
questionRepository.Save();