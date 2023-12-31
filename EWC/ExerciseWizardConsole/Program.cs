
using ExerciseWizardConsole.Repositories;
using ExerciseWizardConsole.Entities;

var questionRepository = new QuestionRepository();

questionRepository.Add(new Question { Content = "Jak na imię miał Napoleon?" });
questionRepository.Save();