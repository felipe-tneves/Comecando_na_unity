using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    //02 - (Detec��o de power-up) Ao coletar um power-up, o
    //personagem aumenta sua velocidade. Se o jogador encontrar um
    //power-up, exiba "Power-up Coletado". Caso contr�rio, exiba
    //"Nenhum power-up encontrado".

    [SerializeField] bool powerUp;//true
    // ! -> Invertendo o valor 

    void Start()
    {
        if (powerUp == true)
        {
            print("Power-up Coletado!");
        }
        else
        {
            print("Nenhum power-up encontrado");
        }

        //condi��o ? Caso vdd : Caso falso 

        print(powerUp ? "Power-up Coletado!" : "Nenhum power-up encontrado");

    }
    void Update()
    {
        
    }
}
