using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class UserSubject : BaseDeletableModel<string>
    {
        public UserSubject()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
