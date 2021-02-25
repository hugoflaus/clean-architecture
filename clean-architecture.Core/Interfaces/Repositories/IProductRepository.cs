using clean_architecture.Core.Entities;

namespace clean_architecture.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
         Product GetById(int id);
         void Add(Product product);
    }
}