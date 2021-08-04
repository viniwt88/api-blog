using blogApi.DbContext;
using blogApi.Interfaces.Repositories;
using blogApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace blogApi.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(BlogContext context, DbSet<User> dbSet) : base(context, dbSet)
        {
        }

        /// <summary>
        /// Retorna um usuario do 'banco'
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<User> VerifyUser(string username, string password) /* : IRepositoryBase<User> */
        {
            // comando só para "habilitar" o async neste caso
            var f = await File.ReadAllLinesAsync("arquivonulo.txt");

            // mockando alguns dados
            var users = new List<User>
            {
                new User {UserId = 1, Username = "autor", Password = "autor", Role = "autor"},
                new User {UserId = 2, Username = "visitante", Password = "visitante", Role = "visitante"},
                new User {UserId = 3, Username = "admin", Password = "admin", Role = "admin"}
            };
            return /* await */ users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == password);
        }

        /// <summary>
        /// Grava um usuário no 'banco'
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CreateUser(User user)
        {
            Context.Add(user);
            return Context.SaveChanges() > 0;
        }
    }
}
