
class Program
{
    static void Main()
    {
        // Variables principales
        int combustible = 30;
        int oxigeno = 50;
        int suministros = 40;
        int integridadNave = 100;
        int diasTranscurridos = 0;
        Random random = new Random(); // Para generar eventos aleatorios
        bool accionValida = false; // Si es true, permite que avance el día y se realicen las consecuencias nocturnas.

        Console.Clear();
        Console.WriteLine("Bienvenido capitán Tadeus, tienes que sobrevivir 10 días para regresar a casa.");
        Console.Write("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
        
        // Bucle principal (cada iteración representa un día)
        while (diasTranscurridos < 10)
        {
            //Estado actual del jugador
            Console.Clear();
            Console.WriteLine("DÍA " + (diasTranscurridos + 1) + " / 10");
            Console.WriteLine("");
            Console.WriteLine("Estado actual:");
            Console.WriteLine("- Combustible: " + combustible + " unidades");
            Console.WriteLine("- Oxígeno: " + oxigeno + " unidades");
            Console.WriteLine("- Suministros: " + suministros + " unidades");
            Console.WriteLine("- Integridad nave: " + integridadNave + "%");
            Console.WriteLine("");

            // Menú de acciones
            Console.WriteLine("Elige tu acción:");
            Console.WriteLine("");
            Console.WriteLine("1. Explorar planeta cercano");
            Console.WriteLine("2. Reparar nave");
            Console.WriteLine("3. Enviar señales");
            Console.WriteLine("4. Rendirse");
            Console.Write("Opción: ");
            string accion = Console.ReadLine();

            accionValida = true;

            if (accion == "1") // Opción 1- Explorar planeta
            {
                if (combustible >= 15)
                {
                    combustible -= 15;
                    Console.WriteLine("");
                    Console.WriteLine("Explorando planeta... (-15 combustible)");
                    Console.ReadLine();

                    // Evento: encontrar oxígeno (60% de probabilidad)
                    if (random.Next(100) < 60)
                    {
                        int oxi = random.Next(20, 41);
                        oxigeno += oxi;
                        Console.WriteLine("Has encontrado " + oxi + " unidades de oxígeno");
                    }
                    
                    // Evento: encontrar combustible (25%)
                    if (random.Next(100) < 25)
                    {
                        int comb = random.Next(10, 31); 
                        combustible += comb;
                        Console.WriteLine("Has encontrado " + comb + " unidades de combustible");
                    }

                    // Evento: encontrar suministros (50%)
                    if (random.Next(100) < 50)
                    {
                        int sum = random.Next(30, 101);
                        suministros += sum;
                        Console.WriteLine("Has encontrado " + sum + " unidades de suministros");
                    }

                    // Evento: tormenta eléctrica (25%)
                    if (random.Next(100) < 25)
                    {
                        int daño = random.Next(10, 21);
                        integridadNave -= daño;
                        Console.WriteLine("Una tormenta eléctrica -" + daño + "% integridad");
                    }

                    // Evento: aterrizaje forzoso (25%)
                    if (random.Next(100) < 25)
                    {
                        int daño = random.Next(10, 21);
                        integridadNave -= daño;
                        Console.WriteLine("Hubo un aterrizaje forzado -" + daño + "% integridad");
                    }
                }
                else
                {
                    Console.WriteLine("No tienes suficiente combustible para explorar");
                }
            }
            else if (accion == "2") // Opción 2- Reparación
            {
                if (integridadNave >= 100)
                {
                    Console.WriteLine("");
                    Console.WriteLine("La nave esta en perecto estado, elige otra acción.");
                    Console.ReadLine();
                    continue; // Salta el resto del bucle y pasa directamente al siguiente día, Evitando gastar suministros o ejecutar lógica que es    innecesaria.
                }

                Console.Write("");
                Console.Write("¿Cuánto porcentaje deseas reparar? (10 suministros por 1%): ");
                string entrada = Console.ReadLine();
                int porcentaje;

                if (int.TryParse(entrada, out porcentaje) && porcentaje > 0) // Validación de entrada, https://stackoverflow.com/questions/9354152/c-sharp-prompting-for-a-boolean-value
                {
                    int maxReparable = 100 - integridadNave;
                    if (porcentaje > maxReparable)
                    {
                        porcentaje = maxReparable;
                        Console.WriteLine("Solo puedes reparar " + maxReparable + "%");
                    }

                    int costo = porcentaje * 10;
                    if (suministros >= costo)
                    {
                        suministros -= costo;
                        integridadNave += porcentaje;
                        Console.WriteLine("Reparado +" + porcentaje + "% (Ahora: " + integridadNave + "%)");
                    }
                    else
                    {
                        Console.WriteLine("Necesitas " + costo + " suministros (tienes " + suministros + ")");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida");
                }
            }
            else if (accion == "3") // Opción 3- Señales de ayuda
            {
                Console.WriteLine("");
                Console.WriteLine("Enviando señales...");
                Console.ReadLine();

                // 50% de probabilidad de recibir ayuda
                if (random.Next(2) == 0)
                {
                    combustible += 60;
                    Console.WriteLine("Has recibido ayuda, +60 combustible");
                }
                else // 50% de probabilidad de ataque pirata
                {
                    integridadNave -= 15;
                    suministros -= 20;
                    Console.WriteLine("Te asaltaron unos piratas, -15% integridad, -20 suministros");
                }
            }
            else if (accion == "4") // Opción 4- Rendirse
            {
                Console.WriteLine("");
                Console.WriteLine("Te has rendido. Game over.");
                break;
            }
            else // Acción inválida: no se reconoce la opción
            {
                Console.WriteLine("");
                Console.WriteLine("Opción no válida");
                Console.ReadLine();
                accionValida = false; // No se puede marcar como válida, por lo tanto no se consumen recursos ni se avanza el día
            }

            if (accionValida) // Solo si se hizo una acción válida, se ejecuta la fase nocturna
            {
                // Noche
                Console.WriteLine("");
                Console.WriteLine("NOCHE");
                oxigeno -= 20;
                suministros -= 30;
                Console.WriteLine("-20 oxígeno, -30 suministros");

                // Condiciones de derrota
                if (oxigeno <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("GAME OVER, Te quedaste sin oxígeno.");
                    break;
                }
                else if (suministros <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("GAME OVER, Te quedaste sin suministros.");
                    break;
                }
                else if (combustible <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("GAME OVER, Te quedaste sin combustible.");
                    break;
                }
                else if (integridadNave <= 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("GAME OVER, Tu nave fue destruida.");
                    break;
                }

                // Eventos aleatorios nocturnos (15% de probabilidad)
                if (random.Next(100) < 15)
                {
                    if (random.Next(100) < 15)
                    {
                        int evento = random.Next(3);

                        if (evento == 0) // Tormenta cósmica
                        {
                            oxigeno -= 10;
                            Console.WriteLine("Hubo una tormenta cósmica, -10 oxígeno");
                        }
                        else if (evento == 1) // Alienígenas
                        {
                            if (random.Next(2) == 0)
                            {
                                combustible += 20;
                                Console.WriteLine("Aparecieron Aliens amigables, +20 combustible");
                            }
                            else
                            {
                                integridadNave -= 10;
                                Console.WriteLine("Aparecieron Aliens hostiles, -10% integridad");
                            }
                        }
                        else // Meteoritos
                        {
                            Console.WriteLine("Hay meteoritos, opción:");
                            Console.WriteLine("1.Esquivar");
                            Console.WriteLine("2.Recibir");
                            string opcion = Console.ReadLine();

                            if (opcion == "1" && combustible >= 10)
                            {
                                int gasto = random.Next(10, 31);
                                combustible -= gasto;
                                Console.WriteLine("Has esquivado los meteoritos -" + gasto + " combustible");
                            }
                            else
                            {
                                int daño = random.Next(15, 26);
                                integridadNave -= daño;
                                Console.WriteLine("Los meteoritos impactaron en la nave -" + daño + "% integridad");
                            }
                        }
                    }
                }
                // Se avanza al siguiente día
                diasTranscurridos++;
                Console.WriteLine("");
                Console.WriteLine("Enter para continuar...");
                Console.ReadLine();
            }
        }

        // Victoría
        if (diasTranscurridos >= 10)
        {
            Console.WriteLine("");
            Console.WriteLine("!FELICIDADES, HAS GANADO¡");
        }

        Console.WriteLine("");
        Console.WriteLine("Juego terminado. Presiona Enter para salir...");
        Console.ReadLine();
    }
}