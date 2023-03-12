using WebCrl_v1.Objects;

namespace WebCrl_v1.Services
{
    public interface IUrlWorker
    {
        UrlWorkResult GetWorkResult(UrlWorkerParams urlParams); 
    }
}
