using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Models
{
    public class Photo
    {
        public long PhotoId { get; private set; }

        public byte[] Content { get; private set; }

        public DateTime PhotoDate { get; private set; }

        //relacionameentos
        public int UserId { get; private set; }

        public virtual User User { get; private set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
