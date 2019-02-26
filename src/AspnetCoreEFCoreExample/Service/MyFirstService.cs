using AspnetCoreEFCoreExample.Models;
using AspnetCoreEFCoreExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreEFCoreExample.Service
{
    public class MyFirstService : IMyFirstService
    {
        private readonly IExampleRepository _exampleRepository;

        public MyFirstService(IExampleRepository exampleRepository)
        {
            _exampleRepository = exampleRepository;
        }

        public IEnumerable<MyModel> GetModels()
        {
            // _exampleRepository.GetAll().ToList().Where(m => m.Id == 1); - bring all from db and filter in memory
            return _exampleRepository.GetAll().Where(m => m.Id == 1).ToList(); // - brings 1 record from db
        }

        public void RemoveSomething(IRemovable removable)
        { 
            removable.Remove();
        }
    }
}
