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
