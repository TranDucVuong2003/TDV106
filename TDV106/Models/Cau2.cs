using System.ComponentModel.DataAnnotations;

namespace TDV106.Models;
    public class One {
        public int? Number {get; set; }
        public decimal? price {get; set; }
        [Key]
        public string? Name {get; set; }
    }
