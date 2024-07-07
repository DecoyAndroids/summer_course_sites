using liveCodingServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Linq;
using Microsoft.Extensions.Hosting;

namespace liveCodingServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    const string FilePath = "posts.json";
    private readonly JsonSerializerOptions _options = new() { WriteIndented = true, PropertyNameCaseInsensitive = true };
    [HttpGet]
    public IActionResult Get()
    {
        if (!System.IO.File.Exists(FilePath))
        {
            return NotFound();
        }        
        string posts = System.IO.File.ReadAllText(FilePath);
        return Ok(posts);
    }
    [HttpPost]
    public  IActionResult CreatePost([FromBody] Post post) 
    {
        if (!System.IO.File.Exists(FilePath))
        {
            return NotFound();
        }
        string postsJson = System.IO.File.ReadAllText(FilePath);
        List<Post> posts = JsonSerializer.Deserialize<List<Post>>(postsJson, _options)!;
        int MaxId = posts[0].id;
        for (int i = 0; i < posts.Count; i++)
        {
            if (MaxId < posts[i].id)
            {
                MaxId = posts[i].id;
            }
        }
        Console.WriteLine(MaxId);
        post.id = MaxId + 1;
        posts.Reverse();
        posts.Add(post);
        posts.Reverse();
        postsJson = JsonSerializer.Serialize(posts, _options);
        System.IO.File.WriteAllText(FilePath, postsJson);   
        return Ok(post);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        string postsJson = System.IO.File.ReadAllText(FilePath);
        List<Post> posts = JsonSerializer.Deserialize<List<Post>>(postsJson, _options)!;
        Post post = posts.SingleOrDefault(p => p.id == id);
        if(post is null)
        {
            return NotFound();  
        }
        return Ok(post);
    }
    [HttpDelete("{id:int}")]
    public IActionResult DeletePost(int id)
    {
        string postsJson = System.IO.File.ReadAllText(FilePath);
        List<Post> posts = JsonSerializer.Deserialize<List<Post>>(postsJson, _options)!;
        List<Post> postsFiltred = []; 
        for (int i = 1; i < posts.Count;i++)
        {
            if (i != id)
            {
                postsFiltred.Add(posts[i]);
                Console.WriteLine(i);
            }
        }
        postsJson = JsonSerializer.Serialize(postsFiltred, _options);
        System.IO.File.WriteAllText(FilePath, postsJson);
        return Ok(postsFiltred);
    }
}
  
