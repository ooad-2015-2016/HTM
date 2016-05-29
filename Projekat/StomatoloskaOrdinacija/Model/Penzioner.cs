﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Penzioner:Pacijent
    {
        public Penzioner(string imePacijenta, string prezimePacijenta, DateTime datumRodjenjaPacijenta) : base(imePacijenta, prezimePacijenta, datumRodjenjaPacijenta)
        {
            StatusPacijenta = "Penzioner";
        }
        public Penzioner() { }
    }
}
