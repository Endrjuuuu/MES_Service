using MES_Service.Models;
using MES_Service.ModelsDTO;
using System.Collections.Generic;

namespace MES_Service.Services.Interfaces
{
    public interface ICityService
    {
        City GetCityByName(string cityName);

        OperationSuccessDTO<IList<City>> GetCities();

        OperationResultDTO UpdateCostOfWorkingHour(string cityName, decimal workingHourCost);

        OperationResultDTO UpdateTransportCost(string cityName, decimal transportCost);

        OperationResultDTO AddCity(City city);

        OperationResultDTO DeleteCity(string cityName);
    }
}