using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Replies
{
    public class AllRepliesViewModel
    {
        public string Content { get; set; }

        public string AuthorUserName { get; set; }

        public string AuthorImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
