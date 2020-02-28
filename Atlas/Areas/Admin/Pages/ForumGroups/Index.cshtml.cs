using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Atlas.Data;
using Atlas.Framework;
using Microsoft.EntityFrameworkCore;

namespace Atlas.Areas.Admin.Pages.ForumGroups
{
    public class IndexModel : BasePageModel
    {
        private readonly AtlasDbContext _dbContext;

        public IndexModel(AtlasDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task OnGetAsync()
        {
            var entities = await _dbContext.ForumGroups.ToListAsync();

            foreach (var entity in entities)
            {
                ForumGroups.Add(new ForumGroup
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    SortOrder = entity.SortOrder
                });
            }
        }

        public IList<ForumGroup> ForumGroups { get; } = new List<ForumGroup>();

        public class ForumGroup
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public int SortOrder { get; set; }
        }
    }
}
