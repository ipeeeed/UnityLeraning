using UnityEngine;

public class EnumScript : MonoBehaviour
{
    public enum Direcoes
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }

    public Direcoes MinhasDirecoes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (MinhasDirecoes)
        {
            case Direcoes.Norte:
                DirecaoSelecionada("Norte");
                break;
            case Direcoes.Sul:
                DirecaoSelecionada("Sul");
                break;
            case Direcoes.Leste:
                DirecaoSelecionada("Leste");
                break;
            case Direcoes.Oeste:
                DirecaoSelecionada("Oeste");
                break;
        }
    }

    void DirecaoSelecionada(string texto) {
        Debug.Log(texto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
