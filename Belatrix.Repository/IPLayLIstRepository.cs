using Belatrix.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Belatrix.Repository
{
    public interface IPlaylistRepository : IRepository<Playlist>
    {
        Playlist GetById(int id);
        
    }
}
