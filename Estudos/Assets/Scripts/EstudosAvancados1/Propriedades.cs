using UnityEngine;

/// <summary>
/// Propriedades ou acessadores são um mecanismo para ler e/ou gravar valor de um campo.
/// </summary>
public class Propriedades : MonoBehaviour
{
    // controle
    private bool isDead { get; set; }
    private bool isWalking { get; set; }

    // atributos
    [SerializeField] private float speed;
    [SerializeField] private string playerName;

    // componentes
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Animator anim;

    // get => fazer a leitura do valor
    // set => modificar o valor
    public float health { get; private set; }

    public float damage {
        get {
            return health - 10f;
        }
    }

    private void Start() {
        Debug.Log(damage);
        Debug.Log(health);
    }
}
