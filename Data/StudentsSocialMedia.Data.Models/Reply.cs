using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class Reply : BaseDeletableModel<string>
    {
        public Reply()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Content { get; set; }

        public string CommentId { get; set; }

        public virtual Comment Comment { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}
