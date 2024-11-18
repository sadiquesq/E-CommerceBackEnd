
using AutoMapper;
using E_Commerce.DTOs;
using E_Commerce.DTOs.CategoryDTO;
using E_Commerce.DTOs.UserDTO;
using E_Commerce.Models;

namespace E_Commerce.Controllers
{

    public class MainAutoMapper : Profile
    {

        public MainAutoMapper() 
        {
            CreateMap<UserInsertDto, User>();

            CreateMap<LoginDto,User>().ReverseMap();

            CreateMap<UserDTO, User>().ReverseMap();


            CreateMap<CategoryInsertDto, Category>().ReverseMap();

            CreateMap<CaregoryViewDto, Category>().ReverseMap();
        }

    }
}
