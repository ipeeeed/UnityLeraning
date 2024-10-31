using System.Collections;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    public int numero1, numero2;
    public int diaSemana = 1;

    // Assim que o jogo começar, este método inicia e executa apenas uma vez.
    void Start()
    {
        // "Debug.Log()" serve para printar no console da Unity.
        Debug.Log(numero1 + " é maior que " + numero2 +"? ");

        // Estrutura If, Else e Else If:
        if (numero1 > numero2)
        {
            Debug.Log("Verdadeirio");
        }
        else if (numero1 < numero2)
        {
            Debug.Log("Falso");
        }
        else
        {
            if (numero1 == numero2)
            {
                Debug.Log("Os dois são iguais");
            }
        }

        // Estrutura Switch Case:
        switch (diaSemana)
        {
            case 1:
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Segunda");
                break;
            case 3:
                Debug.Log("Terça");
                break;
            case 4:
                Debug.Log("Quarta");
                break;
            case 5:
                Debug.Log("Quinta");
                break;
            case 6:
                Debug.Log("Sexta");
                break;
            case 7:
                Debug.Log("Sábado");
                break;
            default:
                Debug.Log("Semana não existente!");
                break;
        }
    }

    // Assim o jogo estiver rodando, este método executa 60x(frames) por segundo.
    void Update()
    {
       
    }
}
