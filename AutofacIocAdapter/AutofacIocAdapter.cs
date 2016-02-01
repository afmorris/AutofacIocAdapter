namespace AutofacIocAdapter
{
    using Autofac;
    using ServiceStack.Configuration;

    public class AutofacIocAdapter : IContainerAdapter
    {
        private readonly IContainer container;

        public AutofacIocAdapter(IContainer container)
        {
            this.container = container;
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }

        public T TryResolve<T>()
        {
            T result;

            if (this.container.TryResolve(out result))
            {
                return result;
            }

            return default(T);
        }
    }
}
