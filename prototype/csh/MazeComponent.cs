﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparison4
{
    interface MazeComponent
    {
        bool isSolid();
        char getSymbol();
        MazeComponent clone();
    }
}
