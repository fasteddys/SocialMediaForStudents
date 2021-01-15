using Microsoft.AspNetCore.Mvc.Rendering;
using StudentsSocialMedia.Data.Common.Repositories;
using StudentsSocialMedia.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Services.Data
{
    public class TownsService : ITownsService
    {
        private readonly IDeletableEntityRepository<Town> townsRepository;

        public TownsService(IDeletableEntityRepository<Town> townsRepository)
        {
            this.townsRepository = townsRepository;
        }

        public IEnumerable<SelectListItem> GetAll()
        {
            IEnumerable<SelectListItem> towns = this.townsRepository
                .All()
                .OrderBy(t => t.Name)
                .Select(t => new SelectListItem
                {
                    Text = t.Name,
                    Value = t.Id,
                })
                .ToList();

            return towns;
        }
    }
}
