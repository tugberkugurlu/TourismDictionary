using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository;
using TourismDictionary.Data.DataAccess.SqlServer;

namespace TourismDictionary.Data.DataAccess.Infrastructure
{
    public interface IMeaningRepository : IRepository<Meaning> {

        IEnumerable<Meaning> GetAll(int wordId);
        Meaning GetSingle(int meaningId);

    }
}
