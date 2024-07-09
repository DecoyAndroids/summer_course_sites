namespace liveCodingServer.Data.Models;

public class Post
{
    public Guid id { get; set; } = new Guid();
    public string title { get; set; }
    public string body { get; set; }
    public int userId { get; set; }
}

