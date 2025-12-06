
// La clase Circulo representa una figura geométrica básica 
// que encapsula su radio y permite calcular su área y perímetro.
public class Circulo
{
    // radio es un dato primitivo (double) encapsulado dentro de la clase
    private double radio;

    // Constructor que recibe el radio e inicializa el objeto
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve un número double con el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve la longitud de la circunferencia
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}


// La clase Rectangulo encapsula el ancho y el alto,
// y contiene métodos para obtener su área y su perímetro.
public class Rectangulo
{
    private double ancho;  // Valor del ancho del rectángulo
    private double alto;   // Valor del alto del rectángulo

    // Constructor que asigna los valores recibidos
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // CalcularArea retorna el área multiplicando ancho por alto
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // CalcularPerimetro suma los lados y multiplica por dos
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}


// Ejemplo sencillo de uso dentro del método Main
public class Program
{
    public static void Main()
    {
        // Se crean dos objetos: un círculo y un rectángulo
        Circulo c = new Circulo(5);
        Rectangulo r = new Rectangulo(4, 6);

        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}
