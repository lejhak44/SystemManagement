using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace IAMS
{
    public class IAMSAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext) {
            //if (!HttpContext.Current.User.Identity.IsAuthenticated) {
            //    base.HandleUnauthorizedRequest(actionContext);
            //} else {
            //    actionContext.Response = new System.Net.Http.HttpResponseMessage(HttpStatusCode.Forbidden);
            //}
            base.HandleUnauthorizedRequest(actionContext);
        }
    }
}