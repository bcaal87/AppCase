﻿// See https://aka.ms/new-console-template for more information
//Variables
int option;
double A;
double B;
double resultado;
string mensaje;

//Dibujar menu
Console.WriteLine("***** CALCULADORA *****");
Console.WriteLine("1. Sumar.");
Console.WriteLine("2. Restar.");
Console.WriteLine("3. Multiplicar.");
Console.WriteLine("4. Dividir.");
Console.WriteLine("5. Elevar a la potencia.");
Console.Write("Seleccione una opción (1 - 5): ");

//Guardar Variable
option = int.Parse(Console.ReadLine());
// Ahora pedimos los dos números.
Console.Write("Ingrese el primer número: ");
A = double.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
B = double.Parse(Console.ReadLine());






