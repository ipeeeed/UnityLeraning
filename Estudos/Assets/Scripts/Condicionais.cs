using System.Collections;
using UnityEngine;

public class Condicionais : MonoBehaviour
{
    public int numero1, numero2;
    public int diaSemana = 1;

    // Assim que o jogo come�ar, este m�todo inicia e executa apenas uma vez.
    void Start()
    {
        // "Debug.Log()" serve para printar no console da Unity.
        Debug.Log(numero1 + " � maior que " + numero2 +"? ");

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
                Debug.Log("Os dois s�o iguais");
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
                Debug.Log("Ter�a");
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
                Debug.Log("S�bado");
                break;
            default:
                Debug.Log("Semana n�o existente!");
                break;
        }
    }

    // Assim o jogo estiver rodando, este m�todo executa 60x(frames) por segundo.
    void Update()
    {
       
    }
}
