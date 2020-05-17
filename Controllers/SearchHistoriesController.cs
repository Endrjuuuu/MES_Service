using MES_Service.Models;
using MES_Service.Services.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace MES_Service.Controllers
{
    public class SearchHistoriesController : ApiController
    {
        private readonly ISearchHistoryService searchHistoryService;

        public SearchHistoriesController(ISearchHistoryService searchHistoryService)
        {
            this.searchHistoryService = searchHistoryService;
        }

        [HttpGet]
        [Route("SearchHistories/GetSearchHistory")]
        public IHttpActionResult GetSearchHistory()
        {
            return Content<IList<SearchHistory>>(HttpStatusCode.OK, searchHistoryService.GetSearchHistories().Result);
        }

        [HttpPost]
        [Route("SearchHistories/AddSearchHistory")]
        [ResponseType(typeof(void))]
        public IHttpActionResult AddSearchHistory(SearchHistory searchHistory)
        {
            if (searchHistory == null)
                return Content(HttpStatusCode.BadRequest, "Object searchHistory is null");

            var response = searchHistoryService.AddSeachHistory(searchHistory);
            if (response.Message.Equals("Success"))
                return Content(HttpStatusCode.OK, "Success");

            return Content(HttpStatusCode.BadRequest, "Error");
        }
    }
}