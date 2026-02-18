using System;

namespace EjerciciosCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ DE EJERCICIOS C# ===");
                Console.WriteLine("1. Positivo, negativo o cero");
                Console.WriteLine("2. Par o impar");
                Console.WriteLine("3. Mayor de edad");
                Console.WriteLine("4. Múltiplo de 5");
                Console.WriteLine("5. Descuento cine (60 años)");
                Console.WriteLine("6. Calificación aprobatoria");
                Console.WriteLine("7. Día de la semana");
                Console.WriteLine("8. Mayor entre dos números");
                Console.WriteLine("9. Mayor entre tres números");
                Console.WriteLine("10. Clasificación de ángulos");
                Console.WriteLine("11. Cálculo de impuestos");
                Console.WriteLine("13. Año bisiesto");
                Console.WriteLine("15. ¿Es un triángulo?");
                Console.WriteLine("17. Tipo de triángulo");
                Console.WriteLine("20. Cálculo de IMC");
                Console.WriteLine("0. Salir");
                Console.Write("\nSelecciona una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

                Console.WriteLine("\n--- Resultado ---");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa un número: ");
                        double n1 = double.Parse(Console.ReadLine());
                        if (n1 > 0) Console.WriteLine("Positivo");
                        else if (n1 < 0) Console.WriteLine("Negativo");
                        else Console.WriteLine("Cero");
                        break;

                    case 2:
                        Console.Write("Ingresa un entero: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(n2 % 2 == 0 ? "Par" : "Impar");
                        break;

                    case 3:
                        Console.Write("Ingresa edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine(edad >= 18 ? "Mayor de edad" : "Menor de edad");
                        break;

                    case 4:
                        Console.Write("Ingresa un número: ");
                        int n4 = int.Parse(Console.ReadLine());
                        Console.WriteLine(n4 % 5 == 0 ? "Es múltiplo de 5" : "No es múltiplo");
                        break;

                    case 10:


                        Console.Write("Grados del ángulo: ");
                        double ang = double.Parse(Console.ReadLine());
                        if (ang < 90) Console.WriteLine("Agudo");
                        else if (ang == 90) Console.WriteLine("Recto");
                        else if (ang < 180) Console.WriteLine("Obtuso");
                        else Console.WriteLine("Llano");
                        break;

                    case 13:
                        Console.Write("Año: ");
                        int anio = int.Parse(Console.ReadLine());
                        bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
                        Console.WriteLine(bisiesto ? "Es bisiesto" : "No es bisiesto");
                        break;

                    case 17:


                   

                        Console.WriteLine("Ingresa los 3 lados:");
                        double la = double.Parse(Console.ReadLine());
                        double lb = double.Parse(Console.ReadLine());
                        double lc = double.Parse(Console.ReadLine());
                        if (la == lb && lb == lc) Console.WriteLine("Equilátero");
                        else if (la == lb || lb == lc || la == lc) Console.WriteLine("Isósceles");
                        else Console.WriteLine("Escaleno");
                        break;

                    case 20:
                        Console.Write("Peso (kg): ");
                        double p = double.Parse(Console.ReadLine());
                        Console.Write("Altura (m): ");
                        double h = double.Parse(Console.ReadLine());
                        double imc = p / Math.Pow(h, 2);
                        string rango = imc switch
                        {
                            < 18.5 => "Bajo peso",
                            < 25 => "Normal",
                            < 30 => "Sobrepeso",
                            _ => "Obesidad"
                        };
                        Console.WriteLine($"IMC: {imc:F2} - Clasificación: {rango}");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
