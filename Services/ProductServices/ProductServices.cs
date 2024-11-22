using AutoMapper;
using E_Commerce.Controllers;
using E_Commerce.DTOs.Pagination;
using E_Commerce.DTOs.ProductDTO;
using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Services.ProductServices
{

  
    public class ProductServices : IProductServices
    {

        private readonly MainDbContext _mainDbContext;
        private readonly IMapper _mapper;

        public ProductServices(MainDbContext mainDbContext, IMapper mapper)
        {
            _mainDbContext = mainDbContext;
            _mapper = mapper;
        }



        public async Task<bool> AddProduct(ProductDTO dTO)
        {
            try
            {
                var de = await _mainDbContext.Products.FirstOrDefaultAsync(c => c.ProductName == dTO.ProductName);
                if (de != null)
                {
                    return false;
                }
                var n = _mapper.Map<Product>(dTO);
                await _mainDbContext.Products.AddAsync(n);
                await _mainDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<List<ProductViewDto>> Viewproducts()
        {
            try
            {
                var p = await _mainDbContext.Products.ToListAsync();
                return _mapper.Map<List<ProductViewDto>>(p);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        public async Task<List<ProductViewDto>> ViewByCategory(string categoryname)
        {
            try
            {
                var p = await _mainDbContext.Categories.Include(r => r.Products).FirstOrDefaultAsync(e => e.CategoryName == categoryname);
                return _mapper.Map<List<ProductViewDto>>(p.Products);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<ProductDTO> Viewproductbyid(Guid id)
        {
            try
            {
                var p = await _mainDbContext.Products.FindAsync(id);
                return _mapper.Map<ProductDTO>(p);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ProductViewDto>> SearchProducts(string name)
        {
            try
            {
                var p = await _mainDbContext.Products.Where(p => p.ProductName.ToLower().Contains(name.ToLower())).ToListAsync();
                return _mapper.Map<List<ProductViewDto>>(p);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public async Task<bool> EditProduct(ProductViewDto product)
        {
            try
            {
                var prod = await _mainDbContext.Products.FirstOrDefaultAsync(n => n.ProductId == product.ProductId);
                if (prod != null)
                {
                    prod.ProductName = product.ProductName;
                    prod.Price = product.Price;
                    prod.stock = product.stock;

                    await _mainDbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<bool> DeleteProduct(Guid id)
        {
            try
            {
                var n = await _mainDbContext.Products.FindAsync(id);
                if (n == null)
                {
                    return false;
                }
                _mainDbContext.Products.Remove(n);
                await _mainDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<PagedResult<ProductViewDto>> viewProductByPagination(paginationParams paginationParams)
        {
            try
            {
                var total = await _mainDbContext.Products.CountAsync();

                var products = await _mainDbContext.Products
                        .OrderBy(p => p.ProductId)
                        .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
                        .Take(paginationParams.PageSize)
                        .ToListAsync();


                var productDtos = _mapper.Map<List<ProductViewDto>>(products);

                return new PagedResult<ProductViewDto>
                {
                    TotalRecords = total,
                    CurrentPage = paginationParams.PageNumber,
                    PageSize = paginationParams.PageSize,
                    Data = productDtos
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }





    }
}
