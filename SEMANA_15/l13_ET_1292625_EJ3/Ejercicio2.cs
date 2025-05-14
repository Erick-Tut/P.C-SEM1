using System;

class Ejercicio2 {
    static void Main() {

        string contraseñaCorrecta = "Contra000";
        SolicitarContraseña(contraseñaCorrecta);

    }

    static void SolicitarContraseña(string contraseñaCorrecta) {

        int intentos = 0;
        bool accesoConcedido = false;

        while (intentos < 3 && !accesoConcedido) {

            Console.Write("Ingrese su contraseña: ");

            string ingreso = Console.ReadLine();

            if (!ValidarFormato(ingreso)) {

                Console.WriteLine("Formato inválido.");

            } else if (ingreso == contraseñaCorrecta) {

                Console.WriteLine("Acceso permitido");
                accesoConcedido = true;

            } else {
                
                Console.WriteLine("Contraseña incorrecta.");

            }

            intentos++;
        }

        if (!accesoConcedido) {
            Console.WriteLine("Acceso denegado");
        }
    }

    static bool ValidarFormato(string contraseña) {

        bool ContMayuscula = false;
        bool ContNumero = false;

        for (int i = 0; i < contraseña.Length; i++) {

            if (contraseña[i] >= 'A' && contraseña[i] <= 'Z')
                ContMayuscula = true;

            if (contraseña[i] >= '0' && contraseña[i] <= '9')
                ContNumero = true;
                
        }

        return ContMayuscula && ContNumero;
    }
}