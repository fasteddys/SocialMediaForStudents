using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class Test : BaseDeletableModel<string>
    {
        public Test()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Participants = new HashSet<TestParticipant>();
        }

        public string SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public virtual ICollection<TestParticipant> Participants { get; set; }
    }
}
