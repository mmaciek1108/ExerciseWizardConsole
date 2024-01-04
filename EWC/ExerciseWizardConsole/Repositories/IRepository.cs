
using ExerciseWizardConsole.Entities;

namespace ExerciseWizardConsole.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
    {

    }
}