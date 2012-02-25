using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourismDictionary.Web.Models { 

    public class WordApiModel {

        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<MeaningApiModel> Meanings { get; set; }
    }
}