using ESG.ESGDbContext;
using ESG.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ESG.ESGDbContext.ESGaction
{
    public class ESGaction : IESGaction
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<ESGmodel> dbset;
        public ESGaction(ApplicationDbContext context)
        {
            _context = context;
            this.dbset = _context.Set<ESGmodel>();
        }
        public IEnumerable<ESGmodel> GetAll()
        {
            return _context.ESGs.ToList();
        }

        public ESGmodel GetFirstOrDefault(Expression<Func<ESGmodel, bool>> filter)
        {
            IQueryable<ESGmodel> query = dbset;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }
    }
}
