using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // SimpleSingleton singleton = new SimpleSingleton();
        // SimpleSingleton.instance.GetSpeed();

        GameController.Instance.speed = 10f;
        GameController.Instance.GetSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
