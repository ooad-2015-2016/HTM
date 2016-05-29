﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Student:Pacijent
    {
        public Student(string imePacijenta, string prezimePacijenta, DateTime datumRodjenjaPacijenta) : base(imePacijenta, prezimePacijenta, datumRodjenjaPacijenta)
        {
            StatusPacijenta = "Student";
        }
        public Student() { }

    }
}
