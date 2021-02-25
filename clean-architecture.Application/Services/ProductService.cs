namespace clean_architecture.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductViewModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductModel productModel)
        {

        }

        public ProductViewModel GetById(int id)
        {
            return new ProductViewModel();
        }
        
    }
}