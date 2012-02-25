using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TourismDictionary.Data.DataAccess.SqlServer {

    public class Meaning {

        [Key]
        public int MeaningId { get; set; }
        public int WordId { get; set; }

        [Required]
        public string Description { get; set; }

        public Word Word { get; set; }
    }
}
