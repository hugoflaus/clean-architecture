using clean_architecture.Core.Entities;
using clean_architecture.Core.Interfaces.Repositories;

namespace clean_architecture.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}