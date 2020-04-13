using System;
using System.Collections.Generic;
using System.Linq;
using AutoMoq;
using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Customers;
using NUnit.Framework;
using Alquiler.Domain.CityCounties;

namespace Alquiler.Application.CityCounties.Queries.GetCityCountyList
{
    [TestFixture]
    public class GetCityCountiesListQueryTests
    {
        private GetCityCountiesListQuery _query;
        private AutoMoqer _mocker;
        private List<CityCounty> _cities;
        private CityCounty _city;

        private const int Id = 1;
        private const string Name = "City 1";

        [SetUp]
        public void SetUp()
        {
            _mocker = new AutoMoqer();

            _city = new CityCounty()
            {
                Id = Id,
                Name = Name
            };

            _cities = new List<CityCounty>()
            {
                _city
            };

            _mocker.GetMock<ICityCountyRepository>()
                .Setup(p => p.GetAll())
                .Returns(_cities.AsQueryable());

            _query = _mocker.Create<GetCityCountiesListQuery>();
        }

        [Test]
        public void TestExecuteShouldReturnListOfCities()
        {
            var results = _query.Execute();

            var result = results.Single();

            Assert.That(result.Id, Is.EqualTo(Id));
            Assert.That(result.Name, Is.EqualTo(Name));
        }
    }
}
