using System;

class Ejercicio1 {
    static void Main(string[] args) {

        Console.Write("Ingrese el número de DNI: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la letra del DNI: ");
        char letra = Convert.ToChar(Console.ReadLine());

        if (comprueba_letra_dni(numero, letra)) {

            Console.WriteLine("Bienvenido");

        }
        else {

            Console.WriteLine("Ha cometido Ud. un error");

        }
    }

    static char letra_dni(int numero) {

        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        int resto = numero % 23;
        return letras[resto];

    }

    static bool comprueba_letra_dni(int numero, char letra) {

        return letra_dni(numero) == letra;
        
    }
}
