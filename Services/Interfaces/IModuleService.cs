using MES_Service.Models;
using MES_Service.ModelsDTO;
using System.Collections.Generic;

namespace MES_Service.Services.Interfaces
{
    public interface IModuleService
    {
        Module GetModuleByName(string moduleName);

        OperationSuccessDTO<IList<Module>> GetModules();

        OperationSuccessDTO<Module> AddModule(Module module);

        OperationSuccessDTO<Module> UpdateModule(Module module);

        OperationSuccessDTO<Module> DeleteModule(string name);
    }
}