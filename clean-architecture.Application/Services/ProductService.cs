using clean_architecture.Application.InputModels;
using clean_architecture.Application.ViewModels;
using clean_architecture.Core.Entities;
using clean_architecture.Core.Interfaces.Repositories;

namespace clean_architecture.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModel productModel)
        {
            var product = new Product();
            _productRepository.Add(product);
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);
            return new ProductViewModel(product.Title, product.Price);
        }
        
    }
}