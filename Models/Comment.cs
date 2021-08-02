using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Models
{
    public class Comment
    {
        public long CommentId { get; private set; }

        public string Content { get; private set; }

        public string CommentDate { get; private set; }

        public int UserId { get; private set; }

        // relações
        public virtual User User { get; private set; }
    }
}
