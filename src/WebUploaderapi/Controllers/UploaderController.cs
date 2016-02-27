using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc;

namespace WebUploaderapi.Controllers
{
    [Route("api/[controller]")]
    public class UploaderController : Controller
    {
        // POST api/uploader
        [HttpPost]
        public IActionResult Post(Utils.FileUpload upload)
        {
            var env = new HostingEnvironment();
            var savepath = env.WebRootPath;

            if (ModelState.IsValid)
            {
                //upload.Set("")
                if (upload.SaveFileAsAsync(HttpContext).Result)
                    return Json(new { ret = 1, src = upload.TargetFilePath });
                else
                    return Json(new { ret = 0, msg = upload.ErrorMessage });
            }
            else
                return Json(new { ret = 0, msg = ModelState.ExpendErrors() });
        }
    }
}
