using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Home
{
    public class CreatePostInputModel
    {
        [Required]
        [MinLength(30)]
        public string Content { get; set; }

        public string SubjectId { get; set; }

        public IEnumerable<SelectListItem> Subjects { get; set; }

        public string CreatorId { get; set; }
    }
}
