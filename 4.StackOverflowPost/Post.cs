public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; private set; } = DateTime.Now;

    public int Votes { get; private set; }

    public void DownVote()
    {
        Votes--;
    }

    public void UpVote()
    {
        Votes++;
    }
}