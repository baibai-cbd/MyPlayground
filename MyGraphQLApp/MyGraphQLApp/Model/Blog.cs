﻿namespace MyGraphQLApp.Model;

public class Blog
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedDate { get; set; }

    public Author Author { get; set; }

    public List<Comment> Comments { get; set; }
}
