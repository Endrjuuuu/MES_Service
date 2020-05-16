using MES_Service.Models;
using MES_Service.ModelsDTO;
using System.Collections.Generic;

namespace MES_Service.Services.Interfaces
{
    public interface ISearchHistoryService
    {
        ResultCostDTO GetSearchHistory(string cityName, ModuleListDTO moduleListDTO);

        OperationSuccessDTO<IList<SearchHistory>> GetSearchHistories();

        OperationResultDTO AddSeachHistory(SearchHistory searchHistory);
    }
}