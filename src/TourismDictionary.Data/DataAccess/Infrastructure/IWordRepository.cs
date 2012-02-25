using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository;
using TourismDictionary.Data.DataAccess.SqlServer;

namespace TourismDictionary.Data.DataAccess.Infrastructure {

    public interface IWordRepository : IRepository<Word> {

        Word GetSingle(int wordId);
    }
}