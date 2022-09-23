﻿using Autofac;
using Library.Areas.Admin.Models;

namespace Library
{
    public class LibraryModule:Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Book>().AsSelf();
            builder.RegisterType<Reader>().AsSelf();
            base.Load(builder);
        }
    }
}
