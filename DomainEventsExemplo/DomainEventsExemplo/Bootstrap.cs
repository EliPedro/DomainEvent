using DomainEventsExemplo.Domain.Handles;
using SimpleInjector;

namespace DomainEventsExemplo
{
    public class Bootstrap
    {
        private static Container container;

        public static void Start()
        {
            container = new Container();

            container.RegisterCollection(typeof(IHandle<>), typeof(IHandle<>).Assembly);
            container.Verify();
        }

        public static Container GetContainer()
        {
            return container;
        }
    }
}