using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProdactController:Controller
    {
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            return Content(id.ToString());
            //return View();
        }
    }
}
