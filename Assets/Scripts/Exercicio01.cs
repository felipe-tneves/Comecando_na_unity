using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
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

        // codinção ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (vidaPlayer > 0) ? "Personagem Vivo!" : "Game Over! ;-;";
        print(resultado);
    }

    void Update()
    {
        
    }
}
