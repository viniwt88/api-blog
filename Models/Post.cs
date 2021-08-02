using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Models
{
    public class Post
    {
        public int PostId { get; private set; }

        public int Title { get; private set; }

        public int Content { get; private set; }

        public DateTime PostDate { get; private set; }

        public ICollection<Comment> Comments { get; private set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        
        // Comportamentos

        // Estados
    }
}
