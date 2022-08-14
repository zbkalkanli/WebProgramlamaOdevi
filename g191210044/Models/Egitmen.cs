using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g191210044.Models
{
    public class Egitmen
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int VerdigiDersId { get; set; }
        [ForeignKey("VerdigiDersId")]
        public Ders Ders { get; set; }
        public int? BlogId { get; set; }
        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }
        public int? YorumId { get; set; }
        [ForeignKey("YorumId")]
        public Yorum Yorum { get; set; }
    }
}