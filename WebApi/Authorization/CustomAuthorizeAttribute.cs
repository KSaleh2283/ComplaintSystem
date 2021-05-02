using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.Entity;
using DataAccess.Context;
using BusniessLogic.SpecificRepository;
using System.Web.Http.Controllers;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Authorization
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(actionContext);
            }
            else
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }
        }


        //    ComplaintContext context = new ComplaintContext(); // my entity  
        //    private readonly string[] allowedroles;
        //    public CustomAuthorizeAttribute(params string[] roles)
        //    {
        //        this.allowedroles = roles;
        //    }
        //    protected override bool AuthorizeCore(HttpContextBase httpContext)
        //    {
        //        bool authorize = false;
        //        foreach (var role in allowedroles)
        //        {
        //            var user = context.Profile.Where(m => m.UserName == httpContext.User.Identity.Name && m.PTRef.Name == role); 
        //            if (user.Count() > 0)
        //            {
        //                authorize = true; /* return true if Entity has current user(active) with specific role */
        //            }
        //        }
        //        return authorize;
        //    }
        //    protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        //    {
        //        filterContext.Result = new HttpUnauthorizedResult();
        //    }
        //}
    }
}