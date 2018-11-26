using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sem2Chal2.Models
{
    public class Games
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameID { get; set; }

        [ForeignKey("AspNetUserId")]
        public AspNetUser Payee { get; set; }

        [Required]
        public string AspNetUserId { get; set; }

        public double? Fee { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString= "{0:yyyy-MM-dd hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime GameDate { get; set; }
    }
}