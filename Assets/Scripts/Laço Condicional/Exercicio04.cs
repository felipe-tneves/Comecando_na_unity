using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    //4. (Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    [SerializeField] bool pocaoVida;

    void Start()
    {
        // condição ? caso vdd : caso falso
        //print(pocaoVida ? "Usando Poção de Vida" : "Poção indisponível");

        if (pocaoVida)
        {
            print("Usando Poção de Vida");
        }
        else
        {
            print("Poção indisponível");
        }
       



    }

    void Update()
    {
        
    }
}
