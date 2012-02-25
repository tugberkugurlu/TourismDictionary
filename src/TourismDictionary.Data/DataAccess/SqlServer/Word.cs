using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TourismDictionary.Data.DataAccess.SqlServer {

    public class Word {

        public Word() {

            this.Meanings = new HashSet<Meaning>();
        }

        [Key]
        public int WordId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Meaning> Meanings { get; set; }
    }
}