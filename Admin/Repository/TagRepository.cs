using Admin.Dtos;
using Admin.IRepository;
using Admin.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Repository
{
    public class TagRepository : ITagRepository
    {
        private ApplicationDbContext db;
        private TagRepository() { }
        public TagRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<TagDto> GetTags()
        {
            var tags = db.Tags.ToList().Select(Mapper.Map<Tags, TagDto>);
            return tags.ToList();
        }
    }
}