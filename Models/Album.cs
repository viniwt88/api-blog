using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Models
{
    public class Album
    {
        public long AlbumId { get; private set; }

        public string AlbumName { get; private set; }

        public DateTime AlbumCreatedIn { get; private set; }


        // relações
        public ICollection<Photo> Photos { get; private set; }

        public long UserId { get; private set; }

        public virtual User User { get; private set; }
    }
}
