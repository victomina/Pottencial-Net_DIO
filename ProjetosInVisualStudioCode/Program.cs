using ExemploFundamentals.Models;

// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
// Console.WriteLine("Minha vida a DEUS eu a dou!!");
// Console.WriteLine("Compilando a minha vida!!");

// Exemlo calculadora

// Calculadora calculadora = new Calculadora();

// calculadora.Somar(12,89);

// calculadora.Potencia(3,3);

// calculadora.Seno(60);
 
// Console.WriteLine("Fim do exemplo de calculadora!!");

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

 // removendo um elemento da fila
 Console.WriteLine($"Removendo o elemento : {fila.Dequeue()}");  //remove o elemtno da fila

fila.Enqueue(7);

 foreach(int item in fila)
 {
    Console.WriteLine(item);                //foreach para cada elemento da fila ==> listar o elemento da fila
 }

Console.WriteLine("Fim do exemplo de fila!!");