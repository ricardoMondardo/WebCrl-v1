using Microsoft.AspNetCore.Mvc;

namespace WebCrl_v1.Controllers
{
    public class UrlWorkerController : Controller
    {

        public string Index()
        {
            return "Welcome to URLWorker Api, EndPoitsAvailable: Welcome(string name)";
        }

        public string Welcome(string name)
        {
            return $"Hello {name}";
        }
    }
}
