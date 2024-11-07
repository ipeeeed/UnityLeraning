using UnityEngine;

public class Parede : MonoBehaviour
{
    public float Velocidade;
    public float Destroi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, Destroi);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Velocidade * Time.deltaTime);
    }
}
