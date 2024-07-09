using liveCodingServer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Linq;
using Microsoft.Extensions.Hosting;
using liveCodingServer.Data.Models;

namespace liveCodingServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    private readonly IPostsRepository _postsRepository;

    public PostsController(IPostsRepository postsRepository)
    {
     _postsRepository = postsRepository; 
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        var posts = _postsRepository.GetAll();
        if (!posts.Any())
        {
            NotFound();
        }
        return Ok(posts);
    }

    [HttpGet("{id:Guid}")]
    public IActionResult GetById(Guid id)
    {
        var post = _postsRepository.GetById(id);
        if (post is null)
        {
            return NotFound();
        }
        return Ok(post);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] PostRequest post) 
    {
        var newPost = await _postsRepository.AddAsync(post);
        return Ok(newPost);
    }

    [HttpPost("{id:Guid}")]
    public async Task<IActionResult> UpdatePost([FromBody] PostRequest post, Guid id)
    {
        var newPost = await _postsRepository.UpdateAsync(post, id);
        return Ok(newPost);
    }

    [HttpDelete("{id:Guid}")]
    public IActionResult DeletePost(Guid id)
    {
        var postsFiltred = _postsRepository.DeleteAsync(id);
        return Ok(postsFiltred);
    }
}
  
