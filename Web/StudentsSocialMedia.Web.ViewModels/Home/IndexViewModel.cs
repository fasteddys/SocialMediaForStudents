﻿using StudentsSocialMedia.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsSocialMedia.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}
