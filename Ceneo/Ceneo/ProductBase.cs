﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceneo
{
    abstract class ProductBase : IProduct
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;

        public string Name { get; private set; }
        public ProductBase(string name)
        {
            this.Name = name;

        }

        public abstract void AddPoints(float score);

        public void AddPoints(string score)
        {

            float scoreToFloat = 0.0F;
            if (float.TryParse(score, out scoreToFloat))
            {
                AddPoints(scoreToFloat);
            }

        }
        public abstract Statistics GetStatistics();

    }
}