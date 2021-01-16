using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
