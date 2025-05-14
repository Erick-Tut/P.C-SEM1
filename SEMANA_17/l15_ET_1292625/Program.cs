using System;

namespace LaboratorioReservas {
    class Program
    {
        static void Main(string[] args)
        {
            AgendaLaboratorio agenda = new AgendaLaboratorio();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("");
                Console.WriteLine("Sistema de Gestion de Reservas de Laboratorio:");
                Console.WriteLine("1. Agregar nueva reserva");
                Console.WriteLine("2. Mostrar todas las reservas ordenadas por fecha");
                Console.WriteLine("3. Buscar reservas por responsable");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarReserva(agenda);
                        break;
                    case "2":
                        agenda.MostrarReservas();
                        break;
                    case "3":
                        Console.Write("Ingrese el nombre del responsable: ");
                        string nombre = Console.ReadLine();
                        agenda.BuscarPersona(nombre);
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void AgregarReserva(AgendaLaboratorio agenda)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("Nueva Reserva");

                Console.Write("Nombre del responsable: ");
                string persona = Console.ReadLine();

                Console.Write("Dia (1-31): ");
                int dia = int.Parse(Console.ReadLine());
                Console.Write("Mes (1-12): ");
                int mes = int.Parse(Console.ReadLine());
                Console.Write("Año: ");
                int año = int.Parse(Console.ReadLine());
                Console.Write("Hora de inicio (8-19): ");
                int horaInicio = int.Parse(Console.ReadLine());
                Console.Write("Hora de fin (9-20): ");
                int horaFin = int.Parse(Console.ReadLine());

                Console.Write("Cantidad de computadoras (1-40): ");
                int cantidad = int.Parse(Console.ReadLine());

                Fecha fecha = new Fecha(dia, mes, año, horaInicio, horaFin);
                ReservaLaboratorio reserva = new ReservaLaboratorio(persona, fecha, cantidad);

                if (agenda.AgregarReserva(reserva))
                {
                    Console.WriteLine("Reserva agregada exitosamente");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar la reserva.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese valores numericos validos");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}