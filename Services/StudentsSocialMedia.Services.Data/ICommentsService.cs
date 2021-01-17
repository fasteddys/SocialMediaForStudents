using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public interface ICommentsService
    {
        IEnumerable<T> GetAll<T>(string postId);
    }
}
