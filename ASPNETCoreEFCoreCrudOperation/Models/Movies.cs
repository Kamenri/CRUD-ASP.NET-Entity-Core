using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreEFCoreCrudOperation.Models
{
    public class Movies
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Please enter Movie Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter Producer Name")]
        public string Producer { get; set; }
        public string Company { get; set; }
        public double RatingOutof10 { get; set; }

    }
}
