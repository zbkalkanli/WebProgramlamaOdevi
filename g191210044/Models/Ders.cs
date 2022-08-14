using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace g191210044.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string DersAdi { get; set; }
        public Tur DersTuru { get; set; }

    }
    public enum Tur
    {
        spor,
        bakım
    }
}