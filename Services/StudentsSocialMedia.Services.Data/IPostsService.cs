using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface IPostsService
    {
        IEnumerable<T> GetAll<T>();
    }
}
