public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // ingresar numeros
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // si es negativo  tirar msj
            if (num1 < 0 || num2 < 0)
            {
                throw new NegativeNumberException("Uno o ambos números son negativos.");
            }

            // div
            double result = num1 / num2;
            Console.WriteLine($"El resultado de la división es: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Formato de número no válido.");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
        finally
        {
            // Mensaje
            Console.WriteLine("La ejecución del bloque try-catch ha finalizado.");
        }
    }
}
