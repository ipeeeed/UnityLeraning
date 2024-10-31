using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] Players;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject Player in Players)
        {
            Debug.Log(Player.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
