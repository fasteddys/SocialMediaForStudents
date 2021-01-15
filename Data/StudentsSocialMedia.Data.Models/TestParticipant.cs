using StudentsSocialMedia.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Data.Models
{
    public class TestParticipant : BaseDeletableModel<string>
    {
        public string ParticipantId { get; set; }

        public virtual ApplicationUser Participant { get; set; }

        public string TestId { get; set; }

        public virtual Test Test { get; set; }
    }
}
