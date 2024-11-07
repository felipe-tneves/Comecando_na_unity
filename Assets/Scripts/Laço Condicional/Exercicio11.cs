using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //11. (Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC(personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    [SerializeField] int estado;

    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Da para fazer com ternario?");
                break;

            case 2:
                print("Sextooou!");
                break;

            case 3:
                print("Cadê o Thiago?");
                break;

            case 4:
                print("Cadê a Alana?");
                break;

            case 5:
                print("Jucelino, cadê meu aumento?");
                break;

            default:
                print("Não tenho nada a dizer sobre isso!");
                break;
        }
    }

    
    void Update()
    {
        
    }
}
