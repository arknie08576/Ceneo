using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ceneo.ProductBase;

namespace Ceneo
{
    public class ProductInFile : ProductBase
    {
        public string filename;
        public override event GradeAddedDelegate GradeAdded;
        public ProductInFile(string name)
            : base(name)
        {
            filename = this.Name + ".txt";
        }

        public override void AddPoints(float score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(filename))
                {
                    
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
                        
                           // line = reader.ReadLine();
                            float point = float.Parse(line);
                            stats.AddGrade(point);

                            line = reader.ReadLine();
                        

                    }

                }
            }
            return stats;
        }
    }
}
