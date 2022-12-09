using ExemploFundamentals.Models;
using System.Globalization;
using ProjetosInVisualStudioCode.Models;
using System;
using Newtonsoft.Json;


List<Vendas> listadeVendas = new List<Vendas>();

//serializando um objeto

Vendas vendas = new Vendas(1 , "Material de computação", 25.00M);
Vendas vendas_1 = new Vendas(2, "Material de escritório", 34.00M);

listadeVendas.Add(vendas);
listadeVendas.Add(vendas_1);

string serializando = JsonConvert.SerializeObject(listadeVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json",serializando);

Console.WriteLine(serializando);

//Seraializando uma lista de objeto





//Exemplo de tupla
// (int, string, string) minhaTupla = (1, "Victor", "Veríssimo");

// Console.WriteLine($"Id :{minhaTupla.Item1}");
// Console.WriteLine($" Nome : {minhaTupla.Item2}");
// Console.WriteLine($"Sobrenome : {minhaTupla.Item3}");



//Exemplo de dictionary
// adicionando comentário adicionando comentário
// Dictionary<string, string> estados =  new  Dictionary<string, string>();

// estados.Add("Ce","Ceará");
// estados.Add("Al","Alagoas");
// estados.Add("Ba","Bahia");


// foreach(var item in estados)
// {
//     Console.WriteLine($" Chave : {item.Key}, valor: {item.Value}");
// }

// estados.Remove("Ba");

// Console.WriteLine("-------------- Fica agora o seguinte dicionário:------------");

// foreach(var item in estados)
// {
//     Console.WriteLine($" Chave : {item.Key}, valor : {item.Value}");
// }


// string chave = "Ba";
// Console.WriteLine($"Verificando se o elemento existe : {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente : {chave}");
// }
// else
// {
//     Console.WriteLine($"O valor não existe!! É seguro adicionar a chave : {chave}");
// }



//Implementação de uma pilha ==> LIFO ==> Last IN First Out


// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(10);
// pilha.Push(12);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento do topo da pilha:{pilha.Pop()}"); 

// pilha.Push(33);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }






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

//  Queue<int> fila = new Queue<int>();
 
//  fila.Enqueue(2);
//  fila.Enqueue(4);
//  fila.Enqueue(6);
//  fila.Enqueue(8);

//  foreach(int item in fila)
//  {
//     Console.WriteLine(item);
//  }

//  // removendo um elemento da fila
//  Console.WriteLine($"Removendo o elemento : {fila.Dequeue()}");  //remove o elemtno da fila

// fila.Enqueue(7);

//  foreach(int item in fila)
//  {
//     Console.WriteLine(item);                //foreach para cada elemento da fila ==> listar o elemento da fila
//  }

// Console.WriteLine("Fim do exemplo de fila!!");