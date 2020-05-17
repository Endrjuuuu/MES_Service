using MES_Service.Models;
using MES_Service.Services.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace MES_Service.Controllers
{
    public class ModuleController : ApiController
    {
        private readonly IModuleService moduleService;

        public ModuleController(IModuleService moduleService)
        {
            this.moduleService = moduleService;
        }

        [HttpGet]
        [Route("Module/Getmodules")]
        public IHttpActionResult GetModules()
        {
            return Content<IList<Module>>(HttpStatusCode.OK, moduleService.GetModules().Result);
        }

        [HttpGet]
        [Route("Module/GetModule/{name}")]
        public IHttpActionResult GetModuleByName(string name)
        {
            if (name == null)
                return NotFound();

            return Content<Module>(HttpStatusCode.OK, moduleService.GetModuleByName(name));
        }

        [HttpPut]
        [Route("Module/UpdateModule")]
        public IHttpActionResult UpdateModule(Module module)
        {
            return Content<string>(HttpStatusCode.OK, moduleService.UpdateModule(module).Message);
        }

        [HttpPost]
        [Route("Module/AddModule")]
        public IHttpActionResult AddModule(Module module)
        {
            return Content<string>(HttpStatusCode.OK, moduleService.AddModule(module).Message);
        }

        [HttpDelete]
        [Route("Module/DeleteModule/{name}")]
        public IHttpActionResult DeleteModule(string name)
        {
            return Content<string>(HttpStatusCode.OK, moduleService.DeleteModule(name).Message);
        }
    }
}