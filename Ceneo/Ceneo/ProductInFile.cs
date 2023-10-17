using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ceneo.ProductBase;

namespace Ceneo
{
    internal class ProductInFile : ProductBase
    {
        private const string filename = "grades.txt";
        public override event GradeAddedDelegate GradeAdded;
        public ProductInFile(string name)
            : base(name)
        {

        }

        public override void AddPoints(float score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(filename))
                {
                    writer.WriteLine(this.Name);
                    writer.WriteLine(score);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }

                }
            }
            else
            {
                throw new Exception("Nieprawidłowa ocena");
            }
        }

        public override Statistics GetStatistics()
        {
            Statistics stats = new Statistics();

            if (File.Exists(filename))
            {
                using (var reader = File.OpenText(filename))
                {

                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (line == this.Name)
                        {
                            line = reader.ReadLine();
                            float point = float.Parse(line);
                            stats.AddGrade(point);

                            line = reader.ReadLine();
                        }
                        else
                        {
                            line = reader.ReadLine();
                            line = reader.ReadLine();
                        }
                    }

                }
            }
            return stats;
        }
    }
}
