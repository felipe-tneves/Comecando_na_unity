using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    //01 - (Verifica��o de pontos de vida) Um personagem perde pontos
    //de vida ap�s uma batalha. Verifique se ele ainda est� vivo. Caso
    //tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
    //contr�rio, "Game Over".


    [SerializeField] int vidaPlayer = 100;
    string resultado;
    void Start()
    {
        if (vidaPlayer > 0)
        {
            print("Personagem vivo! :)");
        }
        else
        {
            print("Game Over");
        }

        // codin��o ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (vidaPlayer > 0) ? "Personagem Vivo!" : "Game Over! ;-;";
        print(resultado);
    }

    void Update()
    {
        
    }
}
