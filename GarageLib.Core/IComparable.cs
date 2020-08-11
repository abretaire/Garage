using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLib.Core
{
    interface IComparable
    {
        void sort();
        int CompareTo(Vehicule vehicule);
    }
}
