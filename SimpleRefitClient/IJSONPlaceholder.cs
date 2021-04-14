using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRefitClient
{
    public interface IJSONPlaceholder
    {
        [Get("/posts")]
        Task<IEnumerable<Post>> GetAllPosts();

        [Get("/posts/{id}")]
        Task<Post> GetPost(int id);
    }

    public record Post(int id, string title, string body, int userId);
}
