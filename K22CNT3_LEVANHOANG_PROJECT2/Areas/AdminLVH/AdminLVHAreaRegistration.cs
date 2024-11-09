using System.Web.Mvc;

namespace K22CNT3_LEVANHOANG_PROJECT2.Areas.AdminLVH
{
    public class AdminLVHAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminLVH";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminLVH_default",
                "AdminLVH/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}