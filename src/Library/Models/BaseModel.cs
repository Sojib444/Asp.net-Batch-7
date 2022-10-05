using Autofac;

namespace Library.Models
{
    public class BaseModel
    {
        protected  ILifetimeScope? _scope;

        public virtual void ResolveDependency(ILifetimeScope scope)
        {
            _scope = scope;
        }
    }
}
