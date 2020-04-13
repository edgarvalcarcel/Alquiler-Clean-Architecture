using System.Collections.Generic;

namespace Alquiler.Application.CityCounties.Queries.GetCityCountyList
{
    public interface IGetCityCountiesListQuery
    {
        List<CityCountyModel> Execute();
    }
}