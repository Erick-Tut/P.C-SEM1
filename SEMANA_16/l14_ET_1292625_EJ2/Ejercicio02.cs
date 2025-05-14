using System;

class EjercicioInventario {
    static void Main(string[] args) {
        bool salir = false;

        string[] nombres = new string[15];
        string[] codigos = new string[15];
        double[] precios = new double[15];
        int[] cantidades = new int[15];
        int cantidadProductos = 0;

        while (!salir) {
            MostrarMenu();
            string opcion = Console.ReadLine();

            if (opcion == "1") {
                if (cantidadProductos < 15) {
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el código del producto: ");
                    string codigo = Console.ReadLine();
                    Console.Write("Ingrese el precio del producto: ");
                    double precio = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad del producto: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    nombres[cantidadProductos] = nombre;
                    codigos[cantidadProductos] = codigo;
                    precios[cantidadProductos] = precio;
                    cantidades[cantidadProductos] = cantidad;

                    cantidadProductos++;

                    Console.WriteLine("Producto agregado exitosamente.");
                } else {
                    Console.WriteLine("El inventario está lleno.");
                }
            }

            else if (opcion == "2") {
                Console.Write("Ingrese el código del producto a modificar el precio: ");
                string codigoModificar = Console.ReadLine();
                bool encontrado = false;

                for (int i = 0; i < cantidadProductos; i++) {
                    if (codigos[i] == codigoModificar) {
                        Console.Write("Ingrese el nuevo precio: ");
                        precios[i] = double.Parse(Console.ReadLine());
                        Console.WriteLine("Precio actualizado.");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado) {
                    Console.WriteLine("Producto no encontrado.");
                }
            }

            else if (opcion == "3") {
                if (cantidadProductos == 0) {
                    Console.WriteLine("El inventario está vacío.");
                } else {
                    Console.WriteLine("Productos en el inventario:");
                    for (int i = 0; i < cantidadProductos; i++) {
                        Console.WriteLine("Nombre: " + nombres[i] + ", Código: " + codigos[i] + ", Precio: " + precios[i] + ", Cantidad: " + cantidades[i]);
                    }
                }
            }

            else if (opcion == "4") {
                if (cantidadProductos == 0) {
                    Console.WriteLine("El inventario está vacío.");
                } else {
                    double valorT = 0;
                    for (int i = 0; i < cantidadProductos; i++) {
                        valorT += precios[i] * cantidades[i];
                    }
                    Console.WriteLine("El valor total del inventario es: " + valorT);
                }
            }

            else if (opcion == "5") {
                salir = true;
            }
        }
    }

    static void MostrarMenu() {
        Console.WriteLine("");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Modificar precio de un producto");
        Console.WriteLine("3. Mostrar productos");
        Console.WriteLine("4. Calcular valor total del inventario");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");
    }
}
