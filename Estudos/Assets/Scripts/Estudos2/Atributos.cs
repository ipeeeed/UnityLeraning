using UnityEngine;

public class Atributos : MonoBehaviour
{
    [HideInInspector] // Oculta variáveis públicas do Inspector
    public int score;

    [Header("Variáveis Numéricas")] // Cabeçalio
    [SerializeField] // Mostra variáveis privadas no Inspector
    private int point;

    [Space] // Espaço apósum campo na unity
    [Header("Outras Váriaveis")] // Outro Cabeçalio
    [Tooltip("Variáveis que não são numéricas")] // É uma instrução para um campo de atributo aopassar o mouse em cima
    public string teste;

    [Range(-5f,5f)] // Barra tipo volume
    public float lifeBar;

    [TextArea] // Área detexto grande
    public string textArea;
}
