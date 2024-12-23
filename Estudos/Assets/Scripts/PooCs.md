# Unity Development [C#]
---
## POO
<!-- Comentários -->
- [using] Importação de recursos de outras Classes <br>
- [namespace] É definido pelo próprio desenvolvedor para organização de grupos <br>
- [class] Modelo de Objeto <br>
- [interface] "Classe" que não implementa métodos <br>
- [struct] Tupla ou valores diversos com um identificador <br>
- [static] <br>
- [delegate] <br>
- [new] Instância de objeto <br>
- [this] Referência a uma variável da Classe atual <br>
- [value] <br>
- [return] Retorno de método ou função com tipagem diferente de void <br>
- [null] Valor nulo <br>
- [var] Variável global <br>
- [event] <br>
- [internal] <br>
- [sealed] <br>
- [yield] <br>
---
### Abstração
- [abstract] <br>
---
### Encapsulamento
- [public] Modificador de acesso aberto <br>
- [private] Modificador de acesso fechado <br>
- [protected] Modificador de acesso aberto apenas para classes herdeiras <br>
- [readonly] 
- [get] Propriedade de consulta <br>
- [set] Propriedade modificadora <br>
---
### Herança
- [:](extends) Herdar de uma classe pai <br>
- [:](implemenst) Implementar uma classe pai <br>
---
### Polimorfismo
**Sobrescrita** <br>
- [virtual] <br>
- [override] <br>
---
**Sobrecarga** <br>
`Quando o mesmo metodo tem tipos ou assinaturas diferentes`
``` C#
    public void metodo(int inteiro){
        ...
    }
    public void metodo(string texto){
        ...
    }
    public string metodo(string texto){
        ...
    }
```

---
### Tipos primitivos
- [void] Tipo vazio <br>
- [const] Valor constante <br>
- [enum] Enumeração de valores <br>
---
- [bool] true e false <br>
- [byte] 0 a 255 <br>
- [sbyte] -128 a 127  <br>
- [int] -2147483648 a 2147483647 <br>
- [uint] 0 a 4294967295 <br>
- [long] -9223372036854775808 a 9223372036854775807 <br>
- [ulong] 0 a 18446744073709551615 <br>
- [short] -32768 a 32767 <br>
- [ushort] 0 a 65535 <br>
- [float] -3.402823E+38 a 3.402823E+38 <br>
- [double] -1.79769313486231E+308d a 1.79769313486231E+308d <br>
- [decimal] 7.9228162514264337593543950335m <br>
- [string] "teste" <br>
- [char] 't' <br>
---
### Estruturas de dados e Lógicos
- [if] <br>
- [else] <br>
- [else_if] <br>
- [switch] <br>
- [break] <br>
- [continue] <br>
- [case] <br>
- [default] <br>
- [for] <br>
- [foreach] <br>
- [while] <br>
- [do_while] <br>
---
### Coleções
- [List] <br>
- [ArrayList] <br>
- [Dictionary] <br>
- [Queue] <br>
- [Stack] <br>
- [Map] <br>
- [LinkedList] <br>
---
### Funções
- [Action] <br>
- [Func] <br>
---
### Tratamento de Exceção
- [try] <br>
- [catch] <br>
- [finally] <br>
- [throw] <br>
---
### Assincronismo
- [async] <br>
- [await] <br>
- [Task] <br>
---







## Cheat-Sheet [Unity]
``` C#
    // EVENT FUNCTIONS
    // Inicialização e Ciclo de Vida
    void Awake(){}                              // 1º: Configurações principais e referências
    void OnEnable(){}                           // Quando o objeto/componente ativa
    void Start(){}                              // Antes do primeiro frame, depois do Awake()
    void OnDisable(){}                          // Quando o objeto/componente desativa
    void OnDestroy(){}                          // Limpeza final antes de destruir

    // Atualizações e Repetições (loops)
    void Update(){}                             // A cada frame - toda a logica do main game
    void FixedUpdate(){}                        // Intervalo de tempo fixo - física apenas
    void LateUpdate(){}                         // Depois da atualizações - cameras e ajustes finais

    // Físicas e Colisões
    void OnCollisionEnter(Collision other){}    // Primeiro toque
    void OnCollisionStay(Collision other){}     // Durante o toque
    void OnCollisionExit(Collision other){}     // Após o toque
    void OnTriggerEnter(Collision other){}      // Entrando na zona de acionamento
    void OnTriggerStay(Collision other){}       // Dentro da zona de acionamento
    void OnTriggerExit(Collision other){}       // Ao sair da zona de acionamento

    // Renderização e Visibilidade
    void OnBecameVisible(){}                    // Objeto entra em qualquer visualização de câmera
    void OnBecameInvisible(){}                  // Objeto sai de todas as visualizações de câmera
    void OnRenderObject(){}                     // Após acamera renderizar a cena
    void OnWillRenderObject(){}                 // Antes de cada renderização de câmera
    void OnGUI(){}                              // IMGUI renderização

    // Aplicações de Fluxos
    void OnAplicationFocus(bool focus){}        // Mudança de foco da janela
    void OnAplicationPause(bool pause){}        // App pausa/continua
    void OnAplicationQuit(){}                   // Antes do app fechar

    // Entrada e Interação
    void OnMouseEnter(){}                       // Mouse entra no colisor
    void OnMouseOver(){}                        // Mouse fica sobre o colisor
    void OnMouseExit(){}                        // Mouse sai do colisor
    void OnMouseDown(){}                        // Mouse clica no colisor
    void OnMouseUp(){}                          // Mouse libera o colisor
    void OnMouseDrag(){}                        // Mouse arrasta o colisor

    // Editor e Desenvolvimento
    void OnDrawGizmos(){}                       // Desenha um gizmo visual para debugar
    void OnDrawGizmosSelected(){}               // Desenha quando selecionado
    void OnValidate(){}                         // Depois ????


    // COMPONENT COMMUNICATION
    // Acesso Direto aos Componentes Unity
    GetComponent<T>();
    GetComponents<T>();
    GetComponentInChildren<T>();
    GetComponentInParent<T>();

    // Pesquisa de componentes a toda a cena
    FindObjectOfType<T>();
    FindObjectsOfType<T>();

    // Pesquisa de GameObject
    GameObject.Find(string name);
    GameObject.FindWithTag(string tag);
    GameObject.FindGameObjectWithTag(string tag);

    // Referências Diretas
    [SerializeField] componentRef;
    cachedComponent;


    // DATA STRUCTURES
    // Coleções Básicos
    int[] fixedArray;                           // Tamanho fixo, memória contínua
    List<T> dynamicList;                        // Tamanho flexivel, GC alocado
    Dictionary<K, V> lookupTable;               // Chave-valor pares, hash-based

    // Coleções Especiais Unity
    [SerializeField]
    SerializedDictionary<K, V> editorDict;      // Dicionário amigável para inspetores
    
    ObservableList<T> reactiveList;             // Lista orientada a eventos
    CircularBuffer<T> ringBuffer;               // Evoltório de tamanho fixo
    ObjectPool<T> recuclePool;                  // Reciclagemd e objetos

    // Alta Performace
    NativeArray<T> burstArray;                  // Matriz compatível com burst
    NativeList<T> burstList;                    // Lista nativa dinamica
    NativeHashMap<K, V> burstDict;              // Dicionário nativo

    // Padrões de Layout de Memória
    struct ComponentData                        // Matrizes paralelas amigáveis ao cache
    {
        float[] positions;
        float[] velocities;
        float[] health;
    }

    // Particionamento Espacial
    SpatialHash<T> worldPartition;              // Pesquisas baseadas no espaço


    // INSPECTOR ATTRIBUTES
    // Serialização de Dados
    [SerializeField]                            // Faz campos privados serem visíveis no Inspector
    [Serializable]                              // Marca classe para serialização
    [Range(min, max)]                           // Adiciona restrições de intervalo numérico
    [Header("Header Text")]                     // Adiciona cabeçalho de seção
    [Tooltip("Tooltip Text")]                   // Mostra informações de foco
    [HideInInspector]                           // Oculta campos públicos
    [Space(10)]                                 // Adiciona espaçamento vertical
    [TextArea]                                  // Texto multilinha com barra de rolagem
    [Multiline]                                 // Texto multilinha sem barra de rolagem
    [ColorUsage(true, true)]                    // Seletor de cores personalizado (HDR, Alpha) 
    [Min(0)]                                    // Define valor mínimo
    [Max(100)]                                  // Define  valor máximo
    [FormerlySerializedAs("oldName")]           // Manter serialização após renomear
    [ContextMenu("Function")]                   // Adiciona contexto ao menu do Inspector
    [ContextMenuItem("Menu", "Function")]       // Adiciona contexto ao campo do menu
    [Delayed]                                   // Atualiza somente após a edição ser concluída
    [NonSerialized]                             // Evita serialização

    // Atributos do editor customizaveis
    [CustomEditor(typeof(Type))]                // Criação de Inspector customizado
    [PropertyDrawer(typeof(Type))]              // Renderização de propriedade personalizada
    [CanEditMultipleObjects]                    // Habilitação de edição de multiplos objetos
    [ExecuteInEditMode]                         // Execução em modo de editor
    [ExecuteAlways]                             // Execução em modo de editor e modo jogador
    [CreateAssetMenu]                           // Criação assets customizados
    [AddComponentMenu("Path")]                  // Adiciona ao menu de componentes
    [DisallowMultipleComponent]                 // Evita duplicação de componentes
    [DefaultExecutionOrder(0)]                  // Define ordem de execução do script
    [HelpURL("URL")]                            // Adiciona link de ajuda documentada
    [InitializedOnLoad]                         // Execução do editor durante carregamento
    [InitializedOnLoadMethod]                   // Método chama durante carregamento
    [SelectionBase]                             // Define meta de seleção primária

    // DEBUGGING
    // Funções de debug de console
    Debug.Log("message");                       // Logs de informações gerais
    Debug.LogWarning("warning");                // Logs de avisos
    Debug.LogError("error");                    // Logs de erros
    Debug.LogAssertion("assert");               // Logs de validação
    Debug.LogException("exception");            // Logs de exceções
    Debug.ClearDeveloperConsole();              // Limpa os logs do console
    Debug.Break();                              // Pause the editor for inspection

    // Debug visual da cena
    Debug.DrawLine(start, end, color);                                  // Desenha linhas na cena
    Debug.DrawRay(origin, direction, color);                            // Visualizar raycast
    Debug.DrawLine(transform.position, targetPos, Color.green, 2f);     // Linha com duração
    Debug.DrawRay(transform.position, Vector3.forward * 10, Color.red); // Raio direcional

    // Editor Gizmos
    void OnDrawGizmos() => 
        Gizmos.DrawSphere(transform.position, 1f);              // Desenha uma linha esferica no objeto
    void OnDrawGizmosSelected() =>
        Gizmos.DrawWireCube(transform.position, Vector3.one);   // Desenha um cubo wireframe
    
    // Perfil de desempenho
    ProfilerMarker marker = new ProfilerMarker("PerformanceMarker");
    marker.Begin();                             // Começa a criar perfil de uma seção
    marker.End();                               // Temina o perfil
    Profiler.BeginSample("SampleTask");         // Inicia um exemplo de perfil customizado
    Profiler.EndSample();                       // Termina o exemplo

    // Debug de Física
    Debug.Break();                                      // Pausa o editor em um frame específico
    Physics.IgnoreCollision(collider1, collider2, true);// Ignora colisores temporáriamente
    Physics.OverlepSphere(transform.position, 5f);      // Visualizar objetos sobrepostos

    // Debug de conexão
    Debug.Log($"Network status: {Application.internetReachability}"); // Checa status de conexão
    Debug.Log($"Host name: {SystemInfo.deviceName}"); // Log do nome do host

    // Utilidades adicionais
    Debug.Log($"Active scene: {UnityEngine.SceneManagement.SceneManager.GetActiveScene().name}");                                                   // Acive scene
    Debug.Log($"Frame count: {Time.frameCount}"); // Log de contagem de frames
    Debug.Log($"Delta time: {Time.deltaTime}"); // Log de tempo entre frames
```
