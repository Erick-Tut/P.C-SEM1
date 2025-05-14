using System;

namespace LaboratorioReservas
{
    public class ReservaLaboratorio
    {
        private string persona;
        private Fecha fecha;
        private int cantidadComputadoras;

        public ReservaLaboratorio(string persona, Fecha fecha, int cantidadComputadoras) {
            this.persona = persona;
            this.fecha = fecha;
            this.cantidadComputadoras = cantidadComputadoras;
        }

        public string Persona { get { return persona; } set { persona = value; } }
        public Fecha Fecha { get { return fecha; } set { fecha = value; } }
        
        public int CantidadComputadoras  { 
            get { return cantidadComputadoras; }
            set {
                if (value >= 1 && value <= 40) {
                    cantidadComputadoras = value;
                }
                else {
                    throw new ArgumentException("La cantidad de computadoras debe estar entre 1 y 40");
                }
            }
        }

        public void MostrarReserva() {
            Console.WriteLine("Responsable: " + persona);
            Console.WriteLine("Fecha: " + fecha.GetDia() + "/" + fecha.GetMes() + "/" + fecha.GetAño());
            Console.WriteLine("Horario: " + fecha.GetHoraInicio() + ":00 - " + fecha.GetHoraFin() + ":00");
            Console.WriteLine("Computadoras reservadas: " + cantidadComputadoras);
            Console.WriteLine("----------------------------------");
        }
    }
}