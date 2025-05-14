using System;

class Ejercicio3{
    static void Main(string[] args) {
        bool salir = false;
        int valor;
        int [] vector = [];
        int cant = 0;
        while (!salir) {

            MostrarMenu();
            string opcion = Console.ReadLine();

            if (opcion == "1") {

                Console.Write("Ingrese la cantidad de datos para llenar: ");
                cant = int.Parse(Console.ReadLine());
                vector = new int [cant];
                
                for (int i = 0; i < cant; i++) {
                    Console.WriteLine("Ingrese el valor:");
                    valor = int.Parse(Console.ReadLine());
                    vector[i] = valor;
                }
            }

            else if (opcion == "2") {
            if (vector.Length == 0 || cant == 0) {
                    Console.WriteLine("El vector está vacío.");
                } else {
                    Console.WriteLine("Lectura de datos:");
                    for (int i = 0; i < cant; i++) {
                        Console.WriteLine("Posición " + i + ": " + vector[i]);
                    }
                }
            }

            else if (opcion == "3") {
                if (vector.Length == 0 || cant == 0) {
                    Console.WriteLine("El vector está vacío.");
                } else {
                    Console.Write("Valores: ");
                    for (int i = 0; i < cant; i++) {
                        Console.Write(vector[i]);
                        if (i < cant - 1) {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            else if (opcion == "4") {
                if (vector.Length == 0 || cant == 0) {
                    Console.WriteLine("El vector está vacío.");
                } else {
                    Console.Write("Ingrese el número que quiere buscar: ");
                    int Buscar = int.Parse(Console.ReadLine());
                    bool Valorx = false;

                    for (int i = 0; i < cant; i++) {
                        if (vector[i] == Buscar) {
                            Console.WriteLine("Número encontrado en la posición " + i);
                            Valorx = true;
                        }
                    }

                    if (!Valorx) {
                        Console.WriteLine("El número no está en el vector.");
                    }
                }
            }

            else if (opcion == "5") {
            if (vector.Length == 0 || cant == 0) {
                Console.WriteLine("El vector está vacío.");
                } else {
                    Console.Write("Ingrese la posición que quiere actualizar (0 a " + (cant - 1) + "): ");
                    int posicion = int.Parse(Console.ReadLine());

                    if (posicion >= 0 && posicion < cant) {
                        Console.WriteLine("Valor actual en la posición " + posicion + ": " + vector[posicion]);
                        Console.Write("Ingrese el nuevo valor: ");
                        int nuevoV = int.Parse(Console.ReadLine());
                        vector[posicion] = nuevoV;
                        Console.WriteLine("Dato actualizado correctamente.");
                    } else {
                        Console.WriteLine("Posición inválida.");
                    }
                } 
            }

            else if (opcion == "6") {
            if (vector.Length == 0 || cant == 0) {
                Console.WriteLine("El vector está vacío. ");
            } else {
                for (int i = 0; i < cant - 1; i++) {
                    for (int j = 0; j < cant - i - 1; j++) {
                        if (vector[j] > vector[j + 1]) {
                            int temp = vector[j];
                            vector[j] = vector[j + 1];
                            vector[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Vector ordenado:");
                for (int i = 0; i < cant; i++) {
                    Console.Write(vector[i]);
                    if (i < cant - 1) {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
                }
            }

            else if (opcion == "7") {
                    salir = true;
            }
            

            static void MostrarMenu() {

                Console.WriteLine("");
                Console.WriteLine("1. Introducir valores");
                Console.WriteLine("2. Leer datos");
                Console.WriteLine("3. Desplegar los datos");
                Console.WriteLine("4. Buscar un dato");
                Console.WriteLine("5. Actualizar un dato");
                Console.WriteLine("6. Ordenar los valores");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

            }  
        }
    }
}