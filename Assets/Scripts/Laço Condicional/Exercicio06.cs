using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    //6. (Escolha de personagem) O jogador pode escolher entre o
    //personagem Guerreiro ou Mago.Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar
    //Mago.

    [SerializeField] bool mago;
    [SerializeField] bool guerreiro;

    void Start()
    {
        if (mago == true && guerreiro == false)
        {
            print("Mago escolhido");
        }
        else if (mago == false && guerreiro == true)
        {
            print("Guerreiro escolhido");
        }
        else if (mago && guerreiro)
        {
            print("Amigo (mão no ombro) só um ;)");
        }
        else
        {
            print("Então não joga");
        }
    }

    void Update()
    {

    }
}
