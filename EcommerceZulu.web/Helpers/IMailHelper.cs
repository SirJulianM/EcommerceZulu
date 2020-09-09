using EcommerceZulu.Common.Responses;

namespace EcommerceZulu.web.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
