using AutoMapper;
using Manga.Application.Interfaces;
using Manga.Data.Interfaces;

namespace MangaBooks
{
    public class MangaBookService : IMangaBookService
    {
        private readonly IRepository<MangaBook> _repository;
        private readonly IMapper _mapper;

        public MangaBookService(
            IRepository<MangaBook> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<MangaBookDto> CreateAsync(MangaBookCreateUpdateDto entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(MangaBookCreateUpdateDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MangaBookDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MangaBookDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MangaBookDto> UpdateAsync(MangaBookCreateUpdateDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
