using UnityEngine;

public class Exer01 : MonoBehaviour
{
    //1. (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "Início da partida!" ao final.
    void Start()
    {
        //for(inicializador; condição; incremento/decremento) 
        for(int i = 5; i > 0; i--)
        {
            print(i);
        }
        print("Início da partida!");
    }

    
    void Update()
    {
        
    }
}
