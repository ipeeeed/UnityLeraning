using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerA player1 = new PlayerA();

        player1.Experience = 10;
        Debug.Log(player1.Experience);

        Sobrecarga sobrecarga = new Sobrecarga();

        sobrecarga.Add(1, 2);
        sobrecarga.Add(3);
        sobrecarga.Add("V1d4", "L0k4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
