using System;
class Ejercicios{
    static void Main() {
/*
// Ejercicio 01

    float suma = 0;
    int cantidad = 0;

    while(suma <= 100){ 
        Console.WriteLine("Ingrese un numero:");
        float num = float.Parse(Console.ReadLine()); 
        suma = suma + num;  
        
        cantidad = cantidad + 1; 
        }

        Console.WriteLine("La suma total es de: " + suma);
        Console.WriteLine("La cantidad de numeros ingresados es de: " + cantidad);
*/
/*
//Ejercicio 02
Console.WriteLine("Ingrese un numero del 1 al 10: ");
        int num = int.Parse(Console.ReadLine()); 
        
        for (int contador = 1; contador <=10; contador++) {

            int resultado = contador * num;

            Console.WriteLine(contador + ": " + resultado);
        } 
*/

/*
//Ejercicio 03
Random random = new Random();
        int NumE = random.Next(1,50);

        Console.WriteLine("Ingrese un numero del 1 al 50: ");
        int num = int.Parse(Console.ReadLine()); 
        
            do{ 
                if(num > NumE){ 
                    Console.WriteLine("El número es menor. Intenta de nuevo: ");
                    num = int.Parse(Console.ReadLine()); 
                } else {
                    Console.WriteLine("El número es mayor. Intenta de nuevo: ");
                    num = int.Parse(Console.ReadLine()); 
                }
            } while (num != NumE);
        Console.WriteLine("¡Felicidades! Has adivinado el número.");
*/

/*
//Ejercicio 04
Console.WriteLine("Ingrese un numero:");
        float num = float.Parse(Console.ReadLine()); 
        
        int cont = 1;
        while (cont <= num)
        {
            for (int ast = 1; ast <= cont; ast++) 
            {
                Console.Write("*");
            }
            Console.WriteLine();
            cont++;
        }
*/
    }
}
