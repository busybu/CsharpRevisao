using System;
using System.Collections.Generic;

// Lista<string> listaString = new Lista<string>();
// listaString.Add("Teste");
// listaString.Add("Teste1");
// listaString.Add("Teste2");

// foreach (var item in listaString.lista)
//     Console.WriteLine(item);

// public class Lista<T>
// {
//     public T[] lista = new T[10];
//     private int index {get; set;} = 0;
    
//     public void Add(T item)
//     {
//         lista[index] = item;
//         index++;
//     }
// }

// public class Stack<T>
// {
//     public T[] stack = new T[10];
//     private int index {get; set;} = 0;

//     public void Push(T item)
//     {
//         if(stack.Length < index)
//         {
//             var temp = new T[stack.Length * 10];
//             for (int i = 0; i < stack.Length; i++)
//             {
//                 temp[i] = stack[i];
//             }
//             stack = temp; 
//         }

//         stack[index] = item;
//         index++;
//     }

//     public void Pop()
//     {
//         if (index == 0)
//             throw new Exception("Não pode index negativo fi");
//         index--;  
//     } 

//     public bool IsEmpty() => index != 0 ? false : true; 

//     public int Size() => index;

//     public void Clear()
//     {
//         for (int i = stack.Length - 1; i >= 0 ; i--)
//         {
//             stack[i] = default(T);
//         }
//         index = 0; 
//     }
//     public override string ToString()
//     {   
//         string txt = "";
//         for (int i = 0; i < index; i++)
//         {
//             txt+= $"{index} - [{stack[i]}]";
//         }
//         return txt;
//     }
// }

List<string> teste = new List<string>()
{
    "123abc", "456def", "olá amiguinhos"
};

var newTeste = formataString(teste, CapitalizeAll);

foreach (var item in newTeste)
{
    System.Console.WriteLine(item);
}
string CaixaAlta(string s)
{
    return s.ToUpper();
}
string CaixaBaixa(string s)
{
    return s.ToLower();
}
string Capitalize(string s)
{
    return char.ToUpper(s[0]) + s.Substring(1);
}
string CapitalizeAll(string s)
{
    var splited = s.Split(" ");
    string result = "";

    foreach(var word in splited)
    {
        result += Capitalize(word) + " ";
    }

    return result;
}
static List<string> formataString(List<string> strList, MudaString func)
{
    List<string> result = new List<string>();
    foreach (var s in strList)
    {
        result.Add(func(s));
    }
    return result; 
}

public delegate string MudaString(string msg);