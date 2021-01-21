using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Posts
{
    public class AllPostsListViewModel
    {
        public IEnumerable<AllPostsViewModel> Posts { get; set; }
    }
}
