namespace ClassDemo01
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            // Instancias de la clase rectángulo u objetos
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.CalcularPerimetro();
            rectangulo.CalcularArea();

            Rectangulo rectangulo2 = new Rectangulo();
            Rectangulo cuadrado = new Rectangulo();
        }

    }
}
