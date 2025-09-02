namespace ClassDemo01
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            // Instancias de la clase rectángulo u objetos
            Rectangulo rectangulo = new Rectangulo(23,50);
            double resultadoArea = rectangulo.CalcularPerimetro();
            double resultadoPerimetro = rectangulo.CalcularArea();

            Rectangulo rectangulo2 = new Rectangulo();
            Rectangulo cuadrado = new Rectangulo();

            (var baseRect, var alturaRect) = rectangulo;

            Console.WriteLine(baseRect);
            Console.WriteLine(alturaRect);

            Console.ReadLine();

        }

    }
}
