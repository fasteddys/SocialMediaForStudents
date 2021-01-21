using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsSocialMedia.Web.Controllers
{
    public class RepliesController : Controller
    {
        public IActionResult All(string id)
        {
            return this.View();
        }
    }
}
