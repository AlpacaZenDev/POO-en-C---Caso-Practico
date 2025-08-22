namespace ClassDemo01
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            // Instancias de la clase rectángulo u objetos
            Rectangulo rectangulo = new Rectangulo(72, 27);
            double resultadoArea = rectangulo.CalcularPerimetro();
            double resultadoPerimetro = rectangulo.CalcularArea();

            Rectangulo rectangulo2 = new Rectangulo();
            Rectangulo cuadrado = new Rectangulo();
        }

    }
}
