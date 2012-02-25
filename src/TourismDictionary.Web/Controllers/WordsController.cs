using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using TourismDictionary.Data.DataAccess.Infrastructure;
using TourismDictionary.Data.DataAccess.SqlServer;

namespace TourismDictionary.Web.APIs.Controllers {

    public class WordsController : ApiController {

        private readonly IWordRepository _wordRepo;

        public WordsController(IWordRepository wordRepo) {

            _wordRepo = wordRepo;
        }

        // GET /api/<controller>
        public IEnumerable<Word> Get() {

            return
                _wordRepo.GetAll();
        }

        // GET /api/<controller>/5
        public Word Get(int id) {

            return 
                _wordRepo.GetSingle(id);
        }

        // POST /api/<controller>
        public void Post(string value)
        {
        }

        // PUT /api/<controller>/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}