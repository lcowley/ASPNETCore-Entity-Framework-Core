using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AspnetCoreEFCoreExample.Models;

namespace AspnetCoreEFCoreExample.Repositories
{
    public interface IExampleRepository
    {
        IQueryable<MyModel> GetAll();
    }

    public class test : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}