using AutoMapper;
using Blog.DTOs;
using Blog.Entity;
namespace Blog.Mapper
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<Category, CreateCategoryDTO>();
        }
    }
}
