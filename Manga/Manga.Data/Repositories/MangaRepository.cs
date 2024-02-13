using Data;
using Manga.Data.Interfaces;
using MangaBooks;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class MangaRepository : IRepository<MangaBook>
    {
        private readonly MangaAppContext _appContext;

        public MangaRepository(MangaAppContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<MangaBook> CreateAsync(MangaBook entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _appContext.MangaBooks.AddAsync(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(MangaBook entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _appContext.MangaBooks.Remove(entity);
            await _appContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<MangaBook>> GetAllAsync()
        {
            return await _appContext.MangaBooks.ToListAsync();
        }

        public async Task<MangaBook> GetAsync(int id)
        {
            return await _appContext.MangaBooks.FindAsync(id);
        }

        public async Task<MangaBook> UpdateAsync(MangaBook entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _appContext.MangaBooks.Update(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }
    }
}
