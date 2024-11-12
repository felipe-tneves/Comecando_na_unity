using NUnit.Framework;
using System.Drawing;
using UnityEngine;

public class Exer07 : MonoBehaviour
{
    //7. (Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.
   
    int[] numeros = { -3, -5, -7, -10, -68, -23, -71, -18, -97, -1 };
    int maior;


    void Start()
    {
        maior = numeros[0];
        
        foreach (var item in numeros)
        {
                       
            if (item > maior)
            {
                maior = item;
            }
        }

        print("O maior número é: " + maior);

    }

    void Update()
    {
        
    }
}
