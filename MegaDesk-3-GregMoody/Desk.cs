﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_GregMoody
{
    class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }

        //Default constructor
        Desk()
        {
            width = 0;
            depth = 0;
            numDrawers = 0;
            surfaceMaterial = "Nothing";
        }

        //Parameter'd input
        Desk(int width, int depth, int numDrawers, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }
    }
}
