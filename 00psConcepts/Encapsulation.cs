﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00psConcepts
{
    public class Encapsulation
    {
        private String studentName;
        private int studentAge;

        public String Name
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return studentAge; }
            set { studentAge = value; }
        }
    }
}
