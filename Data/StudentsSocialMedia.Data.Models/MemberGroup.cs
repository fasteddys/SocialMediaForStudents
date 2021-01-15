using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class MemberGroup : BaseDeletableModel<string>
    {
        public string MemberId { get; set; }

        public virtual ApplicationUser Member { get; set; }

        public string GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
