using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace metroservices.Models
{
    [Table("Tags",Schema="GEO")]
    public class Tag
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId{get;set;}
    }
}