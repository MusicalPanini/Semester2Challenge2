using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sem2Challenge2.Models
{
    public class GameModels
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameID { get; set; }
        [Required]
        public AspNetUser WhosPaying { get; set; }
        [Required]
        public string Venue { get; set; }

        public double FeeAmount { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime GameDate { get; set; }
    }
}