using Ninject;
using Ninject.Modules;
using PayrollPorts.secondary.database;

namespace PayrollDBAdapterJPA
{
    public class JPADatabaseModule
    {
        private readonly JPAPersistenceUnit jpaPersistenceUnit;
        private readonly Database datebase;

        public JPADatabaseModule(JPAPersistenceUnit jpaPersistenceUnit)
        {
            this.jpaPersistenceUnit = jpaPersistenceUnit;
            IKernel injector = createInjector();
            datebase = injector.Get<Database>();
        }
        public static JPADatabaseModule createAndStart(JPAPersistenceUnit jpaPersistenceUnit)
        {
            return new JPADatabaseModule(jpaPersistenceUnit);
        }

        private IKernel createInjector()
        {
            var modules = new INinjectModule[]
            {
                //new MyServiceModule(this),
                //new JpaPersistModule(jpaPersistenceUnitName) // Assuming this is a class you have created
            };

            return new StandardKernel(modules);
        }

        public Database getDatabase()
        {
            return datebase;
        }
    }
}
