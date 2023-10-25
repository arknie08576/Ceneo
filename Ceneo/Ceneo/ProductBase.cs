namespace Ceneo
{
    public abstract class ProductBase : IProduct
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
            else
            {
                throw new Exception("Nieprawidłowa ocena");
            }
        }

        public abstract Statistics GetStatistics();

    }
}
