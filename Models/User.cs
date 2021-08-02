using System.Collections.Generic;

namespace blogApi.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        // 1 user pode ter n albuns
        public virtual ICollection<Album> Albuns { get; set; }

        // 1 user pode ter n postagens
        public virtual ICollection<Post> Posts { get; set; }

        // 1 user pode ter n commentarios
        public virtual ICollection<Comment> Comments { get; set; }

        // 1 user poder ter n fotos
        public virtual ICollection<Photo> Photos { get; set; }



        //Comportamentos:

        //Estados:

    }
}
