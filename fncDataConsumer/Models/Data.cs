using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace fncDataConsumer.Models
{
    
    class Data
    {
        [Key]
        public string NameUser { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EventDate { get; set; }
        [Required]
        public string message { get; set; }

    }
}
