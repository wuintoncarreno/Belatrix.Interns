﻿using System;
using System.Collections.Generic;

namespace Belatrix.Models
{
    public partial class MediaType
    {
        public MediaType()
        {
            Track = new HashSet<Track>();
        }

        public int MediaTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Track> Track { get; set; }
    }
}
