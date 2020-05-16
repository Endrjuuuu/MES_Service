using MES_Service.ModelsDTO;

namespace MES_Service.Services.Interfaces
{
    public interface ICalculatorService
    {
        OperationResultDTO CalculateCost(string cityName, ModuleListDTO moduleListDTO);
    }
}