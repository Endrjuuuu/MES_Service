﻿using MES_Service.Models;
using MES_Service.ModelsDTO;
using MES_Service.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MES_Service.Services.Implementations
{
    public class ModuleService : IModuleService
    {
        private readonly CalculatorContext context;

        public ModuleService(CalculatorContext context)
        {
            this.context = context;
        }

        public OperationSuccessDTO<Module> AddModule(Module module)
        {
            context.Module.Add(module);
            context.SaveChanges();
            return new OperationSuccessDTO<Module> { Message = "Success" };
        }

        public Module GetModuleByName(string moduleName)
        {
            return context.Module.Where(module => module.Name == moduleName).FirstOrDefault();
        }

        public OperationSuccessDTO<IList<Module>> GetModules()
        {
            List<Module> modules = context.Module.ToList();
            return new OperationSuccessDTO<IList<Module>> { Message = "Success", Result = modules };
        }

        public OperationSuccessDTO<Module> DeleteModule(string name)
        {
            var module = context.Module.Where(m => m.Name == name).FirstOrDefault();
            context.Module.Remove(module);
            context.SaveChanges();
            return new OperationSuccessDTO<Module> { Message = "Success" };
        }

        public OperationSuccessDTO<Module> UpdateModule(Module module)
        {
            var mod = context.Module.Where(m => m.Name == module.Name).FirstOrDefault();
            mod.Name = module.Name;
            mod.Price = module.Price;
            mod.Weight = module.Weight;
            mod.AssemblyTime = module.AssemblyTime;
            mod.Code = module.Code;
            mod.Description = module.Description;
            context.SaveChanges();
            return new OperationSuccessDTO<Module> { Message = "Success" };
        }
    }
}