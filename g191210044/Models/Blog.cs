using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g191210044.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Yazi { get; set; }
        public int BegeniSayisi { get; set; }
        public int YazanEgitmenId { get; set; }
        [ForeignKey("Egitmen")]
        public Egitmen Egitmen { get; set; }
    }
}