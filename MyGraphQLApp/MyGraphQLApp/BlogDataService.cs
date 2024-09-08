using MyGraphQLApp.Model;

namespace MyGraphQLApp;

public class BlogDataService
{
    private readonly List<Blog> _blogs;

    public BlogDataService()
    {
        _blogs = GenerateDummyBlogs();
    }

    public List<Blog> GetBlogs()
    {
        return _blogs;
    }

    public Blog GetBlogById(int id)
    {
        return _blogs.FirstOrDefault(b => b.Id == id);
    }

    private static List<Blog> GenerateDummyBlogs()
    {
        var blogs = new List<Blog>();

        blogs.Add(new Blog()
        {
            Id = 1,
            Text = "3rgb349rhj3oeuj102lasds",
            CreatedDate = DateTime.Now.AddMinutes(-10),
            Author = new Author() 
            {
                Id = 1,
                Name = "luodou",
                Nationality = "ZHU"
            },
            Comments = new List<Comment> 
            {
                new Comment() { Id = 1, Text = "comment1" }
            }
        });

        blogs.Add(new Blog()
        {
            Id = 2,
            Text = "nm,.mmuj5675646",
            CreatedDate = DateTime.Now.AddMinutes(-10),
            Author = new Author()
            {
                Id = 1,
                Name = "luodou",
                Nationality = "ZHU"
            },
            Comments = new List<Comment>
            {
                new Comment() { Id = 2, Text = "comment2" }
            }
        });

        blogs.Add(new Blog()
        {
            Id = 3,
            Text = "l9kp0;90ok78i7j7ij",
            CreatedDate = DateTime.Now.AddMinutes(-10),
            Author = new Author()
            {
                Id = 2,
                Name = "ppp",
                Nationality = "KOR"
            },
            Comments = new List<Comment>
            {
                new Comment() { Id = 3, Text = "comment3" }
            }
        });

        blogs.Add(new Blog()
        {
            Id = 4,
            Text = "dfgbny546t34rae",
            CreatedDate = DateTime.Now.AddMinutes(-10),
            Author = new Author()
            {
                Id = 3,
                Name = "ooo",
                Nationality = "THA"
            },
            Comments = new List<Comment>
            {
                new Comment() { Id = 4, Text = "comment4" }
            }
        });

        return blogs;
    }
}
