using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField] bool playerVivo = true;
    [SerializeField] bool power_up = true;
    double vidaPlayer = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if(playerVivo == false && power_up == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda não, vida atual: " + vidaPlayer);

        }
        else if (playerVivo == false && power_up == false)
        {
            print("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
