using System;
using AutoMoq;
using Alquiler.Application.Interfaces.Infrastructure;
using Alquiler.Common.Dates;
using Alquiler.Persistence.Shared;
using StructureMap;

namespace Alquiler.Specification.Shared
{
    public class AppContext
    {
        public AutoMoqer Mocker;
        public IContainer Container;
        public IDatabaseContext DatabaseContext;
        public IInventoryService InventoryService;
        public IDateService DateService;

        public AppContext()
        {
            SetUpAutoMocker();

            SetUpMockDatabase();

            SetUpMockInventoryClient();

            SetUpMockDateService();

            SetUpIocContainer();
        }

        private void SetUpAutoMocker()
        {
            Mocker = new AutoMoqer();
        }

        public void SetUpMockDatabase()
        {
            var mockDatabase = Mocker.GetMock<IDatabaseContext>();

            var intitializer = new DatabaseInitializer(mockDatabase);

            intitializer.Seed();

            DatabaseContext = mockDatabase.Object;
        }

        private void SetUpMockInventoryClient()
        {
            InventoryService =  Mocker.GetMock<IInventoryService>().Object;
        }

        private void SetUpMockDateService()
        {
            var mockDateService = Mocker.GetMock<IDateService>();

            mockDateService
                .Setup(p => p.GetDate())
                .Returns(DateTime.Now);

            DateService = mockDateService.Object;
        }

        private void SetUpIocContainer()
        {
            Container = IoC.Initialize(this);
        }
    }
}
