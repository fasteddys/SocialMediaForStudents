using Microsoft.AspNetCore.Mvc.Rendering;
using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class SubjectsService : ISubjectsService
    {
        private readonly IDeletableEntityRepository<Subject> subjectsRepository;

        public SubjectsService(IDeletableEntityRepository<Subject> subjectsRepository)
        {
            this.subjectsRepository = subjectsRepository;
        }

        public IEnumerable<SelectListItem> GetAll()
        {
            IEnumerable<SelectListItem> subjectsAsListItems = this.subjectsRepository
                .All()
                .OrderBy(s => s.Name)
                .Select(s => new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Id,
                })
                .ToList();

            return subjectsAsListItems;
        }
    }
}
