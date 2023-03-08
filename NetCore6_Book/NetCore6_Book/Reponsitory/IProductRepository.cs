using NetCore6_Book.Data;
using NetCore6_Book.Models;

namespace NetCore6_Book.Reponsitory
{
    public interface IProductRepository
    {
        public Task<List<ProductModel>> GetAllProductAsync();
        public Task<ProductModel> GetProductAsync(int id);
        public Task<int> AddProductAsync(ProductModel model); 
        public Task UpdateProductAsync(int id, ProductModel model);
        public Task DeleteProductAsync(int id);

    }
}
