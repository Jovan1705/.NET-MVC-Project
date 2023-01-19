using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekat1.Models
{
    public class Vozilo
    {
        public string Fotografija { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Godiste { get; set; }
        public double Cena { get; set; }
        public double Popust { get; set; }
        public string Tip { get; set; }
        public string Rate { get; set; }
        public string Opis { get; set; }
    }
}