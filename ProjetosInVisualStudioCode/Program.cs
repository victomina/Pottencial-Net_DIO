using ExemploFundamentals.Models;

// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
// Console.WriteLine("Minha vida a DEUS eu a dou!!");
// Console.WriteLine("Compilando a minha vida!!");

// Exemlo calculadora

Calculadora calculadora = new Calculadora();

calculadora.Somar(12,89);

calculadora.Potencia(3,3);

calculadora.Seno(60);
 
 
 //Exemplo fila ---Queue

 Queue<int> fila = new Queue<int>();
 
 fila.Enqueue(2);
 fila.Enqueue(4);
 fila.Enqueue(6);
 fila.Enqueue(8);

 foreach(int item in fila)
 {
    Console.WriteLine(item);
 }

 