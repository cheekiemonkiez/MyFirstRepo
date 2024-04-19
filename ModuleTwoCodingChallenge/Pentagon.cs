using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoCodingChallenge
{
    class Pentagon : Polygon
    {
        public float Size { get; set; }

        public Pentagon(float size)
        {   Size = size;
            NumberOfSides = 5;
        }
    }
}
