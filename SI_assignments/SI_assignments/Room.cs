﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_assignments
{
    class Room
    {
        private int number;

        public Room(int number)
        {
            this.number = number;
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
    }
}
