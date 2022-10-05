using Autofac;
using Library.Areas.Admin.Models;
using Library.Models;

namespace Library
{
    public class LibraryModule:Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Book>().AsSelf();
            builder.RegisterType<Reader>().AsSelf();
            builder.RegisterType<BookList>().AsSelf();
            builder.RegisterType<BaseModel>().AsSelf();
            base.Load(builder);
        }
    }
}
