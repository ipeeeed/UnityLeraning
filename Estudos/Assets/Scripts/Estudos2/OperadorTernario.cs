using UnityEngine;

public class OperadorTernario : MonoBehaviour
{
    public int life;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string msg = life > 0 ? "Vivo" : "Morto";
        Debug.Log(msg);

        // if (life > 0) {
        //     Debug.Log(msg);
        // }
        // else {
        //     Debug.Log(msg);
        // }
    }
}
