using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ceneo.ProductBase;

namespace Ceneo
{
    internal interface IProduct
    {
        string Name { get; }

        void AddPoints(float score);
        void AddPoints(string score);
        Statistics GetStatistics();

        event GradeAddedDelegate GradeAdded;

    }
}
