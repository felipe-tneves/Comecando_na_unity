using NUnit.Framework;
using System;
using UnityEngine;

public class Exer06 : MonoBehaviour
{
    //6. (Fizz Buzz) Para cada número entre 0 e 10000, escreva apenas
    //“fizz” no console quando for divisível por 3, “buzz” quando for
    //divisível por 5 e “fizz buzz” quando for divisível pelos dois.Se o
    //número não for divisível por nenhum deles, escreva-o no console.

    void Start()
    {
        //for(inicializador; condição; incrementar/decrementar
        for(int i = 0; i < 10000; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                print("Fizz buzz");
            }
            else if (i % 5 == 0)
            {
                print("buzz");
            }
            else if (i % 3 == 0)
            {
                print("Fizz");
            }
            else 
            {
                print(i);
            }
            
        }
    }

    void Update()
    {
        
    }
}
