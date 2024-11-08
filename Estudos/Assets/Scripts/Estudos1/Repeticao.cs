using UnityEngine;

public class Repeticao : MonoBehaviour
{
    public int num = 0;
    public string[] inimigos = new string[3];
    public int itemCena = 2;
    public int dinheiro = 500;

    void Start()
    {
        // Estrutura For
        for (int i = 0; i < num; i++)
        {
            Debug.Log("O numero de inimigos é " + (i+1));
        }

        // Estrutura Foreach
        inimigos[0] = "Goblin";
        inimigos[1] = "Orc";
        inimigos[2] = "Lobo";

        foreach (string inimigo in inimigos)
        {
            Debug.Log(inimigo);
        }

        // Estrutura While
        while (itemCena > 0)
        {
            Debug.Log("Quantidade de Cenas: " + itemCena);
            itemCena--;
        }

        // Estrutura Do While
        do
        {
            Debug.Log("Quantidade de dinheiro: " + dinheiro);
            dinheiro = dinheiro - 250;
        }
        while (dinheiro > 0);
    }

    void Update()
    {
        
    }
}
