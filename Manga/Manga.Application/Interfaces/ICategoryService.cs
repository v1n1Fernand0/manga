using Categories;

namespace Manga.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDto> CreateAsync(CategoryCreateUpdateDto entity);
        Task DeleteAsync( CategoryDto entity);
        Task<CategoryDto> UpdateAsync(CategoryCreateUpdateDto entity);
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetAsync(int id);
    }
}
