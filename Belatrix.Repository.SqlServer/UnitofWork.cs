namespace Belatrix.Repository.SqlServer
{
    public class UnitofWork : IUnitofWork
    {
        public UnitofWork(ChinookContext dbContext)
        {
            Genres = new GenreRepository(dbContext);
            Playlist = new PlaylistRepository(dbContext);
        }

        public IGenreRepository Genres { get; }

        public IPlaylistRepository Playlist { get; }
    }
}
