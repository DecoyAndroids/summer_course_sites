using liveCodingServer.Data;
using liveCodingServer.Data.Models;
using liveCodingServer.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json;

namespace liveCodingServer.Services;

public class PostsRepository:IPostsRepository
{

    private readonly ApplicationDbContext _db;
    public PostsRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public IEnumerable<Post> GetAll()
    {
        return _db.Posts;
    }

    public Post? GetById(Guid id)
    {
        return _db.Posts.FirstOrDefault(p => p.id == id);  
    }

    public async Task<Post> AddAsync(PostRequest request)
    {
        var newPost = new Post
        {
            id = Guid.NewGuid(),
            body = request.body,
            title = request.title,
            userId = request.userId,
        };
        _db.Posts.Add(newPost);
        await _db.SaveChangesAsync(); 
        return newPost;
    }
    public async Task<Post> UpdateAsync(PostRequest request, Guid id)
    {
        var posts = _db.Posts;
        Post post = posts.FirstOrDefault(p => p.id == id);
        posts.Remove(post);
        var updatePost = new Post
        {
            id = id,
            body = request.body,
            title = request.title,
            userId = request.userId,
        };
        _db.Posts.Add(updatePost);
        await _db.SaveChangesAsync();
        return updatePost;
    }
    public async Task<IEnumerable<Post>> DeleteAsync(Guid id)
    {
        var posts = _db.Posts;
        List<Post> postsFiltred = [];
        Post post = posts.FirstOrDefault(p => p.id == id);
        posts.Remove(post);
        _db.Posts = posts;
        await _db.SaveChangesAsync();
        return posts;
    }

}