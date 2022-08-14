using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g191210044.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string MailAdresi { get; set; }
        public Spor IlgilendigiSporlar { get; set; }
        public int? EgitmenId { get; set; }
        [ForeignKey("EgitmenId")]
        public Egitmen Egitmen { get; set; }
        public int YorumId { get; set; }
        [ForeignKey("YorumId")]
        public Yorum Yorum { get; set; }
    }
    public enum Spor
    {
        yoga,
        pilates,
        kardiyo,
        zumba
    }
}