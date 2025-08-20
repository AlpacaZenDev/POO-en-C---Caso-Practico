namespace ClassDemo01
{
    internal partial class Program
    {
        class Rectangulo
        {
            // campos:
            double baseRectangulo;
            double alturaRectangulo;
            string colorRectangulo;

            public Rectangulo()
            {
                baseRectangulo = 0;
                alturaRectangulo = 0;
                colorRectangulo = "Negro";
            }

            // métodos:
            public double CalcularArea()
            {
                return alturaRectangulo * baseRectangulo;
            }
            public double CalcularPerimetro()
            {
                return 2 * (alturaRectangulo + baseRectangulo);
            }
        }
    }
}
