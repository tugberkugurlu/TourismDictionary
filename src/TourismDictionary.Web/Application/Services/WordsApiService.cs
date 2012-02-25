using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourismDictionary.Data.DataAccess.Infrastructure;

namespace TourismDictionary.Web.Application.Services
{
    public class WordsApiService : IWordsApiService {

        private readonly IWordRepository _repo;

        public WordsApiService(IWordRepository repo) {

            _repo = repo;
        }

        public void Add(Models.WordApiModel entity) {

            throw new NotImplementedException();
        }

        public void Delete(Models.WordApiModel entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Models.WordApiModel entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Models.WordApiModel> FindBy(System.Linq.Expressions.Expression<Func<Models.WordApiModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Models.WordApiModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}