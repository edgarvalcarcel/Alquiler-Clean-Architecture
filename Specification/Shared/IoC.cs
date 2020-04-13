using Alquiler.Application.Interfaces.Infrastructure;
using Alquiler.Common.Dates;
using Alquiler.Persistence.Shared;
using StructureMap;
using StructureMap.Graph;

namespace Alquiler.Specification.Shared
{
    public static class IoC
    {
        public static IContainer Initialize(AppContext appContext)
        {
            var container = new Container(x =>
            {
                //SetScanningPolicy();

                x.For<IDatabaseContext>()
                    .Use(appContext.DatabaseContext);

                x.For<IInventoryService>()
                    .Use(appContext.InventoryService);

                x.For<IDateService>()
                    .Use(appContext.DateService);
            });
            return container;
        }

        private static void SetScanningPolicy(IInitializationExpression x)
        {
            x.Scan(scan =>
            {
                scan.AssembliesFromApplicationBaseDirectory(
                    filter => filter.FullName.StartsWith("Alquiler"));

                scan.WithDefaultConventions();
            });
        }
    }
}
