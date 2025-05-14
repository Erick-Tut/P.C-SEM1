using System;

namespace LaboratorioReservas {
    public class AgendaLaboratorio {
        private ReservaLaboratorio[] reservas;
        private int totalReservas;
        private const int MaxReservas = 50;

        public AgendaLaboratorio() {
            reservas = new ReservaLaboratorio[MaxReservas];
            totalReservas = 0;
        }

        public bool AgregarReserva(ReservaLaboratorio nuevaReserva) {
            if (totalReservas >= MaxReservas) {
                return false;
            }

            if (!nuevaReserva.Fecha.EsValida()) {
                return false;
            }

            for (int i = 0; i < totalReservas; i++) {
                if (reservas[i].Fecha.Superpone(nuevaReserva.Fecha))
                {
                    return false;
                }
            }

            reservas[totalReservas] = nuevaReserva;
            totalReservas++;

            for (int i = 0; i < totalReservas - 1; i++) {
                for (int j = 0; j < totalReservas - i - 1; j++) {
                    if (CompararFechas(reservas[j].Fecha, reservas[j + 1].Fecha) > 0) {
                        var temp = reservas[j];
                        reservas[j] = reservas[j + 1];
                        reservas[j + 1] = temp;
                    }
                }
            }

            return true;
        }

         private int CompararFechas(Fecha fecha1, Fecha fecha2) {
            if (fecha1.GetAño() != fecha2.GetAño()) return fecha1.GetAño().CompareTo(fecha2.GetAño());
            if (fecha1.GetMes() != fecha2.GetMes()) return fecha1.GetMes().CompareTo(fecha2.GetMes());
            if (fecha1.GetDia() != fecha2.GetDia()) return fecha1.GetDia().CompareTo(fecha2.GetDia());
            return fecha1.GetHoraInicio().CompareTo(fecha2.GetHoraInicio());
        }

        public void MostrarReservas() {
            if (totalReservas == 0) {
                Console.WriteLine("No hay reservas registradas");
                return;
            }

            Console.WriteLine("");
            Console.WriteLine("Todas las reservas ordenadas por fecha");
            for (int i = 0; i < totalReservas; i++) {
                reservas[i].MostrarReserva();
            }
        }

        public void BuscarPersona(string nombre) {
            bool encontradas = false;

            Console.WriteLine("");
            Console.WriteLine("Reservas a nombre de " + nombre);
            for (int i = 0; i < totalReservas; i++) {
                if (reservas[i].Persona.Equals(nombre, StringComparison.OrdinalIgnoreCase)) {
                    reservas[i].MostrarReserva();
                    encontradas = true;
                }
            }

            if (!encontradas) {
                Console.WriteLine("No se encontraron reservas a nombre de " + nombre);
            }
        }
    }
}