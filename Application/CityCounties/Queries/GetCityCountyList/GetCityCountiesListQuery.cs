using System;
using System.Collections.Generic;
using System.Linq;
using Alquiler.Application.Interfaces.Persistence;

namespace Alquiler.Application.CityCounties.Queries.GetCityCountyList
{
    public class GetCityCountiesListQuery 
        : IGetCityCountiesListQuery
    {
        private readonly ICityCountyRepository _repository;

        public GetCityCountiesListQuery(ICityCountyRepository repository)
        {
            _repository = repository;
        } 
        
        public List<CityCountyModel> Execute()
        {
            var cities = _repository.GetAll()
                  .Select(p => new CityCountyModel()
                  {
                      Id = p.Id,
                      Name = p.Name
                  });

            return cities.ToList();
        }
    }
}
