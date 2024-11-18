using AutoMapper;
using E_Commerce.Controllers;
using E_Commerce.DTOs.UserDTO;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Services
{
    public interface IAdminService
    {
        Task<List<UserDTO>> GetAllUsers();
        Task<UserDTO> GetUserById(Guid id);

        Task<Blocked> BlockOrUnblock(Guid Id);
    }


    public class AdminService: IAdminService
    {

        private readonly MainDbContext _dbContext;
        private readonly IMapper _mapper;


        public AdminService(MainDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


      public async Task<List<UserDTO>> GetAllUsers()
        {
            try
            {
                var p = await _dbContext.Users.ToListAsync();
                return  _mapper.Map<List<UserDTO>>(p);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public async Task<UserDTO> GetUserById(Guid id)
        {

            try
            {
                var dep = await _dbContext.Users.FirstOrDefaultAsync(e => e.UserId == id);
                if (dep == null)
                {
                    return new UserDTO();
                }
                return _mapper.Map<UserDTO>(dep);

            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);

            }
        }


        public async Task<Blocked> BlockOrUnblock(Guid id)
        {
            var us= await _dbContext.Users.SingleOrDefaultAsync(e => e.UserId == id);
            if(us == null)
            {
              return new Blocked { StatusCode=404,Message="user is not found"};
            }
            if (us.IsBlock)
            {
                us.IsBlock = false;
                await _dbContext.SaveChangesAsync();
                return new Blocked { StatusCode = 200, Message = "user is blocked" };
            }
            else
            {
                us.IsBlock = true;
                await _dbContext.SaveChangesAsync();
                return new Blocked { StatusCode = 200, Message = "user is unblocked" };
            }
        }

    }
}
