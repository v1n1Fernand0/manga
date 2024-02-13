using MangaBooks;

namespace Manga.Application.Interfaces
{
    public interface IMangaBookService
    {
        Task<MangaBookDto> CreateAsync(MangaBookCreateUpdateDto entity);
        Task DeleteAsync(MangaBookCreateUpdateDto entity);
        Task<MangaBookDto> UpdateAsync(MangaBookCreateUpdateDto entity);
        Task<IEnumerable<MangaBookDto>> GetAllAsync();
        Task<MangaBookDto> GetAsync(int id);
    }
}
