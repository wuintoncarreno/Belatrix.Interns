using Belatrix.Models;

namespace Belatrix.Repository.MySql
{
    public class UnitofWork : IUnitofWork
    {
        public UnitofWork(ChinookContext dbContext)
        {
            Genres = new GenreRepository(dbContext);
            Artists = new Repository<Artist>(dbContext);
            Playlists = new Repository<Playlist>(dbContext);
        }
        public IGenreRepository Genres { get; }

        public IRepository<Artist> Artists { get; }

        public IRepository<Playlist> Playlists { get; }
    }
}
