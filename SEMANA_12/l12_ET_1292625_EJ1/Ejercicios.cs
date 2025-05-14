using System;
class Ejercicios
{
 static void Main()
 {

/*
 // Ejercicio 01

 Console.Write("Ingresa una palabra: ");
 string palabra = Console.ReadLine();
 
 string invertida = "";
 
 for (int i = palabra.Length - 1; i >= 0; i--)
 {
 
 invertida += palabra[i];
 }


 Console.WriteLine("Palabra invertida: " + invertida);
 
  if(palabra == invertida){
 Console.WriteLine("La palabra es un palindromo");
 } else {
 Console.WriteLine("La palabra no es un palindromo");
 }
*/

/*
 // Ejercicio 02

 
 Console.Write("Ingresa una frase: ");
 string frase = Console.ReadLine().ToLower(); 

 int conta = 0;
 int conte = 0;
 int conti = 0;
 int conto = 0;
 int contu = 0;

 foreach (char letra in frase)
 {
 
 if ("a".Contains(letra))
 {
 conta++;
 }
  if ("e".Contains(letra))
 {
 conte++;
 }
  if ("i".Contains(letra))
 {
 conti++;
 }
  if ("o".Contains(letra))
 {
 conto++;
 }
  if ("u".Contains(letra))
 {
 contu++;
 }
 }

 Console.WriteLine("A: " + conta + ", E: " + conte + ", I: " + conti + ", O: " + conto + ", U: " + contu);
*/

/*
// Ejercicio 03

 Console.Write("Ingresa una frase: ");
 string frase = Console.ReadLine();
 
 Console.Write("Frase a reemplazar: ");
 string original = Console.ReadLine();
 Console.WriteLine();
 
 Console.Write("Nueva Frase: ");
 string nuevo = Console.ReadLine();
 Console.WriteLine();
 
 string modificada = frase.Replace(original, nuevo);
 
 Console.WriteLine("Frase modificada: " + modificada);
 */
 }
}