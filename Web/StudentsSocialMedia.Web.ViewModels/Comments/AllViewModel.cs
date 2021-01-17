using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Comments
{
    public class AllViewModel
    {
        public string Content { get; set; }

        public string AuthorUserName { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
