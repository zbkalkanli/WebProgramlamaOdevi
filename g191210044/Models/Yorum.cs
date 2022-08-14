using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g191210044.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        public string YorumYazisi { get; set; }
        public string BegeniSayisi { get; set; }
        public int YapanUyeId { get; set; }
        [ForeignKey("YapanUyeId")]
        public Uye Uye { get; set; }
        public int YapanEgitmenId { get; set; }
        [ForeignKey("YapanEgitmenId")]
        public Egitmen Egitmen { get; set; }
    }
}