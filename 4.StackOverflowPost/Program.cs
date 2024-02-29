var post = new Post{
    Title = "New Post",
    Description = "Description"
};

post.UpVote();
post.UpVote();

post.DownVote();

Console.WriteLine($"Post current votes : {post.Votes}");