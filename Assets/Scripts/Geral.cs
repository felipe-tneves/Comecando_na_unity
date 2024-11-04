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

        Operadores L�gicos

        && (E/ AND)
        || (OU / OR)
        ! (N�O / NOT)
     
        Vari�veis
    
        int vidaPlayer = 10;
        float velocidadePlayer = 50.2f;
        bool mortePlayer = true;
        string nomePlayer = "Tadola";
        char apelido = 'A';
    */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;

    void Start()
    {
        print(vidaVilao == vidaHeroi);//false
        print(vidaHeroi <= vidaVilao);//true
        print(vidaVilao != vidaHeroi);//true

        //Operador tern�rio
        //codi��o ? valor a ser atribuido caso verdadeiro : caso falso
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);

        //Estrutura condicional
        if(vidaHeroi < vidaVilao)
        {
            resultado = "Vida Heroi Menor";
            print(resultado);

        }
        else if(vidaHeroi == vidaVilao)
        {
            resultado = "Vida Heroi igual a vida Vilao";
            print(resultado);

        }
        else
        {
            resultado = "Vida Heroi Maior";
            print(resultado);
        }

    }

    void Update()
    {
       
    }

}