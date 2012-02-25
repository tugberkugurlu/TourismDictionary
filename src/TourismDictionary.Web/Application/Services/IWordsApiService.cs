using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourismDictionary.Web.Models;
using GenericRepository;

namespace TourismDictionary.Web.Application.Services
{
    public interface IWordsApiService : IRepository<WordApiModel>
    {
    }
}