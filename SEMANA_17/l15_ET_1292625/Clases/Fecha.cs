using System;

namespace LaboratorioReservas {
    public class Fecha {
        private int dia;
        private int mes;
        private int año;
        private int horaInicio;
        private int horaFin;

        public Fecha(int dia, int mes, int año, int horaInicio, int horaFin) {
            this.dia = dia;
            this.mes = mes;
            this.año = año;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }

         public void SetDia(int dia) {
            this.dia = dia;
        }

        public void SetMes(int mes) {
            this.mes = mes;
        }

        public void SetAño(int año) {
            this.año = año;
        }

        public void SetHoraInicio(int horaInicio) {
            this.horaInicio = horaInicio;
        }

        public void SetHoraFin(int horaFin) {
            this.horaFin = horaFin;
        }

        public int GetDia() {
            return dia;
        }

        public int GetMes() {
            return mes;
        }

        public int GetAño() {
            return año;
        }

        public int GetHoraInicio() {
            return horaInicio;
        }

        public int GetHoraFin() {
            return horaFin;
        }

        public bool EsValida() {
            if (GetMes() < 1 || GetMes() > 12) {
                return false;
            }

            if (GetDia() < 1) {
                return false;
            }

            switch (GetMes()) {
                case 2:
                    if (GetDia() > 28) return false;
                    break;
                case 4: case 6: case 9: case 11:
                    if (GetDia() > 30) return false;
                    break;
                default:
                    if (GetDia() > 31) return false;
                    break;
            }

            if (GetHoraInicio() >= GetHoraFin()) {
                return false;
            }

            if (GetHoraInicio() < 8 || GetHoraFin() > 20) {
                return false;
            }

            return true;
        }

        public bool Superpone(Fecha otraFecha) {
            if (GetDia() != otraFecha.GetDia() || 
                GetMes() != otraFecha.GetMes() || 
                GetAño() != otraFecha.GetAño()) {
                return false;
            }

            return !(GetHoraFin() <= otraFecha.GetHoraInicio() || 
                   otraFecha.GetHoraFin() <= GetHoraInicio());
        }
    }
}