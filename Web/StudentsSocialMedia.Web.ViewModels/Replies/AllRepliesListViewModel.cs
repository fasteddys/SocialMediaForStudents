using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Replies
{
    public class AllRepliesListViewModel
    {
        public IEnumerable<AllRepliesViewModel> Replies { get; set; }

        public int RepliesCount => this.Replies.Count();
    }
}
