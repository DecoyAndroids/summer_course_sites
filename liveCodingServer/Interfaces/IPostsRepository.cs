using liveCodingServer.Data.Models;

namespace liveCodingServer.Interfaces
{
    public interface IPostsRepository
    {
        public IEnumerable<Post> GetAll();
        public Post? GetById(Guid id);
        public Task<Post> AddAsync(PostRequest request);
        public Task<Post> UpdateAsync(PostRequest request, Guid id);
        public Task<IEnumerable<Post>> DeleteAsync(Guid id);
    }
}
