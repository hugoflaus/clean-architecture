using clean_architecture.Application.ViewModels;

namespace clean_architecture.Application.Services
{
    public interface IProductService
    {
         ProductViewModel GetById(int id);
    }
}