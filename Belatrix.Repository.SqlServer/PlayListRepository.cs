using Belatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Belatrix.Repository.SqlServer
{
    public class PlaylistRepository : Repository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(ChinookContext dbContext) : base(dbContext)
        {
        }

        public Playlist GetById(int id)
        {
           return _dbContext.Playlist.FirstOrDefault(x => x.PlaylistId == id);
        }
    }
}
