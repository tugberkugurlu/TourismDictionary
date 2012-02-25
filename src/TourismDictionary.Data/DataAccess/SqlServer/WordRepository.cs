using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TourismDictionary.Data.DataAccess.Infrastructure;
using GenericRepository.EF;

namespace TourismDictionary.Data.DataAccess.SqlServer
{
    public class WordRepository : Repository<GlossaryContext, Word>, IWordRepository {

        public Word GetSingle(int wordId)
        {
            return
                Context.Words.Include("Meanings").FirstOrDefault(x => x.WordId == wordId);
        }
    }
}
