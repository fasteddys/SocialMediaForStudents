using StudentsSocialMedia.Web.ViewModels.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface IUsersService
    {
        UserViewModel GetByUsername(string username);
    }
}
