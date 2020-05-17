using MES_Service.ModelsDTO;
using MES_Service.Services.Interfaces;
using System.Net;
using System.Web.Http;

namespace MES_Service.Controllers
{
    public class ShowResultController : ApiController
    {
        private readonly IShowResultService showResultService;

        public ShowResultController(IShowResultService showResultService)
        {
            this.showResultService = showResultService;
        }

        [HttpPost]
        [Route("ShowResult/Get")]
        public IHttpActionResult GetCost(ShowResultDTO showResultDTO)
        {
            var result = this.showResultService.PresentResult(showResultDTO.CityName, showResultDTO.ModuleListDTO);

            if (result.Cost == -1)
                return Content<string>(HttpStatusCode.ExpectationFailed, "Error, probably bad module name");

            return Content<ResultCostDTO>(HttpStatusCode.OK, this.showResultService.PresentResult(showResultDTO.CityName, showResultDTO.ModuleListDTO));
        }
    }
}