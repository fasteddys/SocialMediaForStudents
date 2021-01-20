using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface ISubjectsService
    {
        IEnumerable<SelectListItem> GetAll();
    }
}
