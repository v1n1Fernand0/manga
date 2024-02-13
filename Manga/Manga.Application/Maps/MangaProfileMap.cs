using AutoMapper;
using Categories;
using MangaBooks;

namespace Maps
{
    public class MangaProfileMap : Profile
    {
        public MangaProfileMap()
        {
            CreateMap<CategoryCreateUpdateDto, CategoryDto>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CategoryCreateUpdateDto, Category>().ReverseMap();

            CreateMap<MangaBookCreateUpdateDto, MangaBookDto>().ReverseMap();
            CreateMap<MangaBookDto, MangaBook>().ReverseMap();
            CreateMap<MangaBookCreateUpdateDto, MangaBook>().ReverseMap();
        }
    }
}
