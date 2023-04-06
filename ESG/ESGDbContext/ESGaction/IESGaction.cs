using ESG.Models;
using System.Linq.Expressions;

namespace ESG.ESGDbContext.ESGaction
{
    public interface IESGaction
    {
        IEnumerable<ESGmodel> GetAll();
        ESGmodel GetFirstOrDefault(Expression<Func<ESGmodel, bool>> filter);
    }
}
