using System;
using Unity.VisualScripting;
using UnityEngine;

public class Desafio02 : MonoBehaviour
{
    //Faça um algoritmo que receba o dia, o mês e o ano em que uma pessoa nasceu, 
    //imprima na tela quantos anos, meses e dias essa pessoa já viveu.
    //Leve em consideração o ano com 365 dias e o mês com 30 dias.

    [SerializeField] int diaNascimento;
    [SerializeField] int mesNascimento;
    [SerializeField] int anoNascimento;

    void Start()
    {
        //Data atual
        int diaAtual = DateTime.Now.Day;
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        ////Calcular ano vividos
        //int anosVividos = anoAtual - anoNascimento;

        ////Calcular meses vividos
        //int mesesVividos = mesAtual - mesNascimento;

        //if(mesesVividos < 0)
        //{
        //    anosVividos--;
        //    //mesesVividos = mesesVividos + 12;
        //    mesesVividos += 12;
        //}

        ////Calcular dias vividos
        //int diasVividos = diaAtual - diaNascimento;

        //if(diasVividos < 0)
        //{
        //    mesesVividos--;
        //    diasVividos += 30;

        //    if(mesesVividos < 0)
        //    {
        //        anosVividos--;

        //        //mesesVividos = mesesVividos + 12;
        //        mesesVividos += 12;
        //    }
        //}

        //print("Você viveu: " +  diasVividos + " dias, " + mesesVividos + " meses, " + anosVividos + " anos");

        //total de dias vividos
        int totalDiasVividos = (anoAtual - anoNascimento) * 365 + (mesAtual - mesNascimento) * 30 + (diaAtual - diaNascimento);

        //Converte para anos, meses e dias restantes
        int anosVividos = totalDiasVividos / 365;
        int mesesVividos = (totalDiasVividos % 365) / 30;
        int diasVividos = (totalDiasVividos % 365) % 30;

        print("Você viveu: " + diasVividos + " dias, " + mesesVividos + " meses, " + anosVividos + " anos");
    }

    void Update()
    {
        
    }
}
