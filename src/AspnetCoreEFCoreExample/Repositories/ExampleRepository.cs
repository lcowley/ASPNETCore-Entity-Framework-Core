using System.Collections.Generic;
using System.Linq;
using AspnetCoreEFCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreEFCoreExample.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly DataBaseContext _ctx;

        public ExampleRepository(DataBaseContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<MyModel> GetAll()
        {
            return _ctx.MyModels.Include(m => m.SecondModel);
        }
    }
}