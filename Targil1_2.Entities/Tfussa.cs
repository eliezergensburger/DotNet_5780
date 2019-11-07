using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1_2.Entities
{
    public class Tfussa
    {
        bool[,] mat = new bool[12, 31];

        public bool[,] Mat { get => mat; set => mat = value; }
        public bool this[int[] indexes]
        {
            get { return mat[indexes[0], indexes[1]]; }
            set { mat[indexes[0], indexes[1]] = value; }
        }
    }
}
