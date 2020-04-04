using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace market.Models
{
    public class Clothes
    {
        [Key]
        public int id { set; get; }
        [Column(TypeName = "nvarchar(250)")]
        public string name { set; get; }
        [Column(TypeName =  "nvarchar(4000)")]
        public string description { set; get; }
        [Column(TypeName = "varchar(250)")]
        public int price { set; get; }
        [Column(TypeName =  "nvarchar(250)")]
        public string material { set; get; }
        [Column(TypeName = "nvarchar(250)")]
        public string imageSrc { set; get; }

    }
}
