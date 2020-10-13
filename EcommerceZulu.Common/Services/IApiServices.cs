using EcommerceZulu.Common.Responses;
using System.Threading.Tasks;

namespace EcommerceZulu.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }

}
