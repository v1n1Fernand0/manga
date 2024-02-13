using Categories;
using Data;
using Manga.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Manga.Data.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly MangaAppContext _appContext;

        public CategoryRepository(MangaAppContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<Category> CreateAsync(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _appContext.Categories.AddAsync(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _appContext.Categories.Remove(entity);
            await _appContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _appContext.Categories.ToListAsync();
        }

        public async Task<Category> GetAsync(int id)
        {
            return await _appContext.Categories.FindAsync(id);
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _appContext.Categories.Update(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }
    }
}
