using AutoMapper;
using E_Commerce.Controllers;
using E_Commerce.DTOs;
using E_Commerce.DTOs.UserDTO;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Commerce.Services
{


    public interface IAuthService
    {
        Task<bool> CheckRegister(UserInsertDto dto);
        void Rgister(UserInsertDto dto);


        Task<User> Login(LoginDto login);
    }
    public class AuthService : IAuthService
    {

        private readonly MainDbContext _mainDbContext;
        private readonly IMapper _mapper;

        public AuthService(IMapper mapper,MainDbContext mainDbContext)
        {
   
            _mapper = mapper;
            _mainDbContext = mainDbContext;
        }


        public async Task<bool> CheckRegister(UserInsertDto dto)
        {
            var n= _mainDbContext.Users.FirstOrDefault(x=> x.Email == dto.Email);
            if (n != null)
            {
             return false;
            }
            return true;
        }

        public void Rgister(UserInsertDto dto)
        {
            var haspassword = BCrypt.Net.BCrypt.HashPassword(dto.Password);
            dto.Password = haspassword;
            var n = _mapper.Map<User>(dto);
            _mainDbContext.Users.Add(n);
            _mainDbContext.SaveChanges();
        }

        
        public async Task<User> Login(LoginDto login)

        {  
            var p =await  _mainDbContext.Users.FirstOrDefaultAsync(e => login.Email == e.Email );
            if(p ==null)
            {
                return new User();
            }
            bool pass = BCrypt.Net.BCrypt.Verify(login.Password, p.Password);
            if (!pass)
            {
                return new User(); 
            }
            return p;
        }


















    }
}
