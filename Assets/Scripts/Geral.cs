using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{
    /*
        Operadores relacionais
        
        == (igual)
        != (diferente)
        >  (Maior que)
        <  (Menor que)
        <= (Menor igual)
        >= (Maior igual)

        Operadores Lógicos

        && (E/ AND)
        || (OU / OR)
        ! (NÃO / NOT)
     
        Variáveis
    
        int vidaPlayer = 10;
        float velocidadePlayer = 50.2f;
        bool mortePlayer = true;
        string nomePlayer = "Tadola";
        char apelido = 'A';
    */

    //[SerializeField] int vidaHeroi = 100;
    //[SerializeField] int vidaVilao = 300;
    //string resultado;

    [SerializeField] int estadoVilao = 1;

    void Start()
    {
        //print(vidaVilao == vidaHeroi);//false
        //print(vidaHeroi <= vidaVilao);//true
        //print(vidaVilao != vidaHeroi);//true

        //Operador ternário
        //codição ? valor a ser atribuido caso verdadeiro : caso falso
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);

        //Estrutura condicional
        //if(vidaHeroi < vidaVilao)
        //{
        //    resultado = "Vida Heroi Menor";
        //    print(resultado);

        //}
        //else if(vidaHeroi == vidaVilao)
        //{
        //    resultado = "Vida Heroi igual a vida Vilao";
        //    print(resultado);

        //}
        //else
        //{
        //    resultado = "Vida Heroi Maior";
        //    print(resultado);
        //}

        //estado 01: vilão ataca
        //estado 02: vilão defende
        //estado 03: vilão toma dano

        switch (estadoVilao)
        {
            case 1:
                print("Vilaão atacando");
                if (true)
                {
                    print("Danoo");
                }
                break;

            case 2:
                print("Vilão defende");
                break;


            case 3:
                print("Vilão tomando um coro");
                break;

            default:
                print("Valor não identificado");
                break;
        }

    }

    void Update()
    {

    }

}
