using AutoMapper;
using FreeCourse.Services.Catalog.Dtos.CategoryDtos;
using FreeCourse.Services.Catalog.Dtos.CourseDto;
using FreeCourse.Services.Catalog.Dtos.FetaureDtos;
using FreeCourse.Services.Catalog.Model;

namespace FreeCourse.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();

        }
    }
}