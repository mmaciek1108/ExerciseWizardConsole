
using ExerciseWizardConsole.Repositories;
using ExerciseWizardConsole.Entities;
using ExerciseWizardConsole.Data;

var questionRepo = new SqlRepository<Question>(new EwcDBContext());
AddQuestions(questionRepo);
AddTests(questionRepo);
WriteAllToConsole(questionRepo);

static void AddQuestions(IRepository<Question> questionRepository)
{
    questionRepository.Add(new Question { Content = "Za co dostał nagrodę Nobla Max Planck?" });
    questionRepository.Add(new Question { Content = "Kto dostał nagrobę Nobla w 1921r.?" });
    questionRepository.Save();
}
static void AddTests(IWriteRepository<MultipleAnswerTests> multipleTestRepository)
{
    multipleTestRepository.Add(new MultipleAnswerTests
    {
        Content = "Fala świetlna to fala elektromagnetyczna",
        MultipleAnswer = "A. Tak \n B. Nie"
    });
    multipleTestRepository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}