using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Omni.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private string KanaResult
        {
            get
            {
                return "{ \"AllResultsUrl\":\"http://wsrv4457.rabobank.corp/RaboITPortalService/Portal/StartSession?searchFor=outlook+start&searchType=Natural\",\"ResultCount\":138,\"Results\":[{\"Guid\":\"{472be088-13ba-4691-a160-2b45aa9e01dc}\",\"ObjectType\":\"Vraag\",\"Summary\":\"\",\"Title\":\"Oplossen foutmelding Kan (exchange) server niet vinden in Outlook      \",\"Url\":\"http://wsrv4457.rabobank.corp/RaboITPortalService/Portal/StartSession?guid={472be088-13ba-4691-a160-2b45aa9e01dc}&objtype=Vraag&searchFor=outlook+start&searchType=Natural\"},{\"Guid\":\"{7e431daf-8188-49a9-b803-59ef1acf0077}\",\"ObjectType\":\"Decision Tree\",\"Summary\":\"\",\"Title\":\"Stappenplan: Oplossen problemen opstarten Outlook\",\"Url\":\"http://wsrv4457.rabobank.corp/RaboITPortalService/Portal/StartSession?guid={7e431daf-8188-49a9-b803-59ef1acf0077}&objtype=Decision Tree&searchFor=outlook+start&searchType=Natural\"},{\"Guid\":\"{34947e9b-b55a-445f-9ff9-7d6af90b927f}\",\"ObjectType\":\"Vraag\",\"Summary\":\"\",\"Title\":\"Skyp for Business/Outlook starts with pop-up     \",\"Url\":\"http://wsrv4457.rabobank.corp/RaboITPortalService/Portal/StartSession?guid={34947e9b-b55a-445f-9ff9-7d6af90b927f}&objtype=Vraag&searchFor=outlook+start&searchType=Natural\"}]}";
            }
        }

        [HttpGet("[action]")]
        public string SearchResults()
        {
            return KanaResult;
        }
    }
}
