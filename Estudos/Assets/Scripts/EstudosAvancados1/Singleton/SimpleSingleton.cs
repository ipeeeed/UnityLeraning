using UnityEngine;

/// <summary>
/// Singleton é um design pattern usado quanto precisamos chamar métodos e variáveis de uma classe sem precisar de referência.
/// </summary>
public class SimpleSingleton : MonoBehaviour
{
    public float speed;
    public static SimpleSingleton instance { get; private set; }
    
    private void Awake() {
        instance = this;
    }

    public void GetSpeed() {

    }
}
