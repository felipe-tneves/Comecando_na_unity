using UnityEngine;

public class Exer04 : MonoBehaviour
{
    //4. (Pontuação em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontuação total após 7 combos.

    [SerializeField] int pontuacao = 0;

    void Start()
    {
        for(int combo = 1; combo <= 7; combo++)
        {
            //pontuacao = pontuacao + 10;
            pontuacao += 10;
        }

        print("Pontuação total: " +  pontuacao);
    }

    void Update()
    {
        
    }
}
