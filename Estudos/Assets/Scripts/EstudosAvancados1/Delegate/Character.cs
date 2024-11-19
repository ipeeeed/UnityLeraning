using UnityEngine;

/// <summary>
/// Exemplo multi-cast
/// </summary>
public class Character : MonoBehaviour
{
    private void OnEnable() {
        // assinala com os 2 métodos
        DelegateExample.myDelegate += DebugName;
        DelegateExample.myDelegate += DestroyMyObj;
    }

    void Start()
    {
        // chama o delegate

        // if (DelegateExample.myDelegate != null)
        // {
        //     DelegateExample.myDelegate();
        // }

        // Verifica se DelegateExample é nulo
        DelegateExample.myDelegate?.Invoke();
    }

    private void OnDisable()
    {
        // retira assinatura dos metodos
        if (DelegateExample.myDelegate == null) {
            return;
        }
        DelegateExample.myDelegate -= DebugName;
        DelegateExample.myDelegate -= DestroyMyObj;
    }

    public void DebugName() {
        Debug.Log("Pedro Pedro Pedro");
    }

    public void DestroyMyObj() {
        Destroy(gameObject);
    }
}
