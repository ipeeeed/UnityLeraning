using UnityEngine;

public class Estaticos : MonoBehaviour
{
    public int vidas = 3;
    public static Estaticos estaticos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        estaticos = this;
    }

    public void AumentarVida()
    {
        Debug.Log(vidas);
    }
}
