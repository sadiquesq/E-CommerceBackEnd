using E_Commerce.DTOs.Pagination;
using E_Commerce.DTOs.ProductDTO;

namespace E_Commerce.Services.ProductServices
{
    public interface IProductServices
    {
        Task<bool> AddProduct(ProductDTO dTO);
        Task<List<ProductViewDto>> Viewproducts();
        Task<List<ProductViewDto>> ViewByCategory(string categoryname);
        Task<ProductDTO> Viewproductbyid(Guid id);
        Task<List<ProductViewDto>> SearchProducts(string name);
        Task<bool> EditProduct(ProductViewDto product);

        Task<bool> DeleteProduct(Guid id);

        Task<PagedResult<ProductViewDto>> viewProductByPagination(paginationParams paginationParams);


    }
}
