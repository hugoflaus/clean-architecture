using clean_architecture.Application.InputModels;
using clean_architecture.Application.ViewModels;
using clean_architecture.Core.Interfaces.Repositories;

namespace clean_architecture.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productModel)
        {

        }

        public ProductViewModel GetById(int id)
        {
            return new ProductViewModel();
        }
        
    }
}