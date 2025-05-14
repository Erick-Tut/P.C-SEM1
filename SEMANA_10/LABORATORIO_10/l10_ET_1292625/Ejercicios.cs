
using System;

class Ejercicios {
    static void Main() {
/*   
    //Ejercicio 01

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 12) {
            Console.WriteLine("Eres un Niño.");
        } else if (edad >= 12 && edad <= 17) {
            Console.WriteLine("Eres un Adolescente.");
        } else if (edad >= 18 && edad <= 64) {
            Console.WriteLine("Eres un Adulto.");
        } else {
            Console.WriteLine("Eres un Adulto mayor.");
        }
*/   

/*
     //Ejercicio 02
     Console.Write("Ingrese la calificación dada entre 0 a 100: ");
        int calificacion = int.Parse(Console.ReadLine());

        if (calificacion >= 0 && calificacion <= 59) {
            Console.WriteLine("Reprobado");
        } else if (calificacion >= 60 && calificacion <= 79) {
            Console.WriteLine("Aprobado");
        } else if (calificacion >= 80 && calificacion <= 89) {
            Console.WriteLine("Notable");
        } else if (calificacion >= 90 && calificacion <= 100) {
            Console.WriteLine("Excelente");
        } else {
            Console.WriteLine("Calificación inválida.");
        }
*/

/*
// Ejercicio 03
Console.WriteLine("Seleccione su categoría de usuario:");
        Console.WriteLine("1. Adulto");
        Console.WriteLine("2. Estudiante");
        Console.WriteLine("3. Adulto Mayor");
        Console.WriteLine("4. Niño");
        Console.WriteLine("5. Salir");
        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        double tarifaN = 10.0;
        double tarifaF = tarifaN;

        switch (opcion) {
            case 1:
                Console.WriteLine("Tarifa a pagar: " + tarifaF);
                break;
            case 2:
                tarifaF = tarifaF * 0.5;
                Console.WriteLine("Tarifa a pagar " + tarifaF);
                break;
            case 3:
                tarifaF = tarifaF * 0.7;
                Console.WriteLine("Tarifa a pagar " + tarifaF);
                break;
            case 4:
                Console.Write("Ingrese la edad del niño: ");
                int edadN = int.Parse(Console.ReadLine());
                if (edadN < 5) {
                    Console.WriteLine("Tarifa gratuita.");
                } else if (edadN >= 5 && edadN<= 12) {
                    tarifaF = tarifaF * 0.5;
                    Console.WriteLine("Tarifa a pagar: " + tarifaF);
                } else {
                    Console.WriteLine("Tarifa a pagar: " + tarifaF);
                }
                break;
            case 5:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
*/
    }
}
