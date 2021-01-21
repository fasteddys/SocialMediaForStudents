using StudentsSocialMedia.Data.Models;
using StudentsSocialMedia.Data.Models.Enumerations;
using StudentsSocialMedia.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Profiles
{
    public class AboutViewModel : IMapFrom<ApplicationUser>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string TownName { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
