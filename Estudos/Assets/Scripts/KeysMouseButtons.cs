using UnityEngine;

public class KeysMouseButtons : MonoBehaviour
{
    // OnMouse - Conjunto de métodos de interação do mouse.
    private void OnMouseDown()
    {
        Debug.Log("Clicou");
    }

    void Update()
    {
        // Input - Usada para interações do jogador.
        // GetKey - Capta cada frame com a tecla pressionada.
        // GetKeyUp - Capta uma vez a tecla ao pressionar.
        // GetKeyDown - Capta uma vez a tecla após pressionar.
        // KeyCode - Usada para definir qual tecla do teclado será usada.

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Pulando");
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Agachando");
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Direita");
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Esquerda");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Atira");
        }

        if (Input.GetKey(KeyCode.O))
        {
            Debug.Log("Carrega Arma");
        }
    }
}
