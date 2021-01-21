using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Comments
{
    public class AllViewModelList
    {
        public IEnumerable<AllViewModel> Comments { get; set; }

        public int CommentsCount => this.Comments.Count();
    }
}
