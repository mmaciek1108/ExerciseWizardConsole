
using ExerciseWizardConsole.Entities;

namespace ExerciseWizardConsole.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}