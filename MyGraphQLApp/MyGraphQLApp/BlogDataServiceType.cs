namespace MyGraphQLApp;

public class BlogDataServiceType : ObjectType<BlogDataService>
{
    protected override void Configure(IObjectTypeDescriptor<BlogDataService> descriptor)
    {
        base.Configure(descriptor);

        descriptor.Field(b => b.GetBlogs())
            .Type<NonNullType<ListType<BlogType>>>();

        descriptor.Field(b => b.GetBlogById(default))
            .Argument("id", b => b.Type<NonNullType<IdType>>());

    }
}
