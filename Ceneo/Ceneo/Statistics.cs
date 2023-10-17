using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceneo
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Average { get; private set; }
        public int Count { get; private set; }
        public float Sum { get; private set; }

        public Statistics()
        {
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Average = 0;
            this.Count = 0;
            this.Sum = 0;

        }

        public void AddGrade(float grade)
        {
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
            this.Count++;
            this.Sum += grade;
            this.Average = this.Sum / this.Count;

        }
    }
}
