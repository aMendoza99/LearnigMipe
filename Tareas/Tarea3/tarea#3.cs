//class Program
//{
//    static void Main(string[] Arrays)
//    {
//        // Arreglo edades
//        int[] edades = { 24, 25, 30, 20, 22 };

//        // Arreglo Nombres
//        string[] nombres = { "Adrien", "Julian", "Matillas", "Ennio", "Antony" };

//        // Logica que presenta Nombre y edad que tiene
//        for (int i = 0; i < nombres.Length; i++)
//        {
//            Console.WriteLine($"{nombres[i]} tiene {edades[i]} años");
//        }

//        // llamado que presenta Saludo personalizado
//        for (int i = 0; i < nombres.Length; i++)
//        {
//            string mensaje = SaludoPersonalizado(nombres[i], edades[i]);
//            Console.WriteLine(mensaje);
//        }
//    }

//    // Funcion que genera mmensaje personalizado
//    static string SaludoPersonalizado(string nombre, int edad)
//    {
//        return $"Hola {nombre}, tienes {edad} años. ¡Que tengas un buen día!";
//    }
//}