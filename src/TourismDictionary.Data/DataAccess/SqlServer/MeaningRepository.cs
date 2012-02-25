using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using TourismDictionary.Data.DataAccess.Infrastructure;

namespace TourismDictionary.Data.DataAccess.SqlServer {

    public class MeaningRepository : Repository<GlossaryContext, Meaning>, IMeaningRepository
    {
        public IEnumerable<Meaning> GetAll(int wordId) {

            return
                GetAll().Where(x => x.WordId == wordId);
        }

        public Meaning GetSingle(int meaningId)
        {
            return
                GetAll().FirstOrDefault(x => x.MeaningId == meaningId);
        }
    }
}