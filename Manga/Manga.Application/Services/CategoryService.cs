using AutoMapper;
using Categories;
using Manga.Application.Interfaces;
using Manga.Data.Interfaces;

namespace Manga.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<CategoryDto> CreateAsync(CategoryCreateUpdateDto entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CategoryDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> UpdateAsync(CategoryCreateUpdateDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
