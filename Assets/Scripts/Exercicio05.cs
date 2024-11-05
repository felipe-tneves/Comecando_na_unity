using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio05 : MonoBehaviour
{
    //5. (Pontuação de missão) Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".

    [SerializeField] int pontos = 0;

    void Start()
    {
        if (pontos >= 50)
        {
            print("Missão bem - sucedida");
        }
        else
        {
            print("Missão incompleta");
        }

        // condição ? caso vdd : caso falso (Ternario)
        print(pontos >= 50 ? "Missão bem - sucedida" : "Missão incompleta");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
