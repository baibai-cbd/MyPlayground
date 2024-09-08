using MyGraphQLApp.Model;

namespace MyGraphQLApp;

public class BlogType : ObjectType<Blog>
{
    protected override void Configure(IObjectTypeDescriptor<Blog> descriptor)
    {
        base.Configure(descriptor);

        descriptor.Field(a => a.Id)
            .Type<NonNullType<IdType>>();

        descriptor.Field(a => a.Text)
            .Type<NonNullType<StringType>>();

        descriptor.Field(a => a.CreatedDate)
            .Type<NonNullType<DateTimeType>>();

        descriptor.Field(a => a.Author)
            .Type<NonNullType<AuthorType>>();


        descriptor.Field(a => a.Comments)
            .Type<NonNullType<ListType<NonNullType<CommentType>>>>();

    }
}

public class AuthorType : ObjectType<Author>
{
    protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
    {
        base.Configure(descriptor);

        descriptor.Field(a => a.Id)
            .Type<NonNullType<IdType>>();

        descriptor.Field(a => a.Name)
            .Type<NonNullType<StringType>>();

        descriptor.Field(a => a.Nationality)
            .Type<NonNullType<StringType>>();
    }
}

public class CommentType : ObjectType<Comment>
{
    protected override void Configure(IObjectTypeDescriptor<Comment> descriptor)
    {
        base.Configure(descriptor);

        descriptor.Field(a => a.Id)
            .Ignore();

        descriptor.Field(a => a.Text)
            .Type<NonNullType<StringType>>();
    }
}
