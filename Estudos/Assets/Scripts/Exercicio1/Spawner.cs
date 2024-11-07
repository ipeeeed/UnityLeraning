using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnerTempo;
    public List<GameObject> Paredes = new List<GameObject>();

    void Start()
    {
        
    }

    float TempoCont;
    void Update()
    {
        TempoCont += Time.deltaTime;

        if (TempoCont >= SpawnerTempo)
        {
            Instantiate(Paredes[Random.Range(0, Paredes.Count)], transform.position, transform.rotation);
            TempoCont = 0f;
        }
    }
}
