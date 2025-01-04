#region POO C#
// Comentário de uma linha para escrever anotações importantes.
/*
    Comentário de multiplas linhas para textos importantes.
    Comentário de multiplas linhas para textos importantes.
    Comentário de multiplas linhas para textos importantes.
*/

// [using] Importação de recursos de outras Classes.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Classes
// [namespace] É definido pelo próprio desenvolvedor para organização de grupos.
namespace JogoGrupoClasses
{
    /// <summary>
    /// Sumário para explicar sobre o que se trata o código.
    /// As classes a serem mostrados neste grupo serão exemplos de tipos de classes.
    /// </summary>

    // [class] Modelo dos Objetos.
    // [MonoBehaviour] Classe principal da Unity.
    // Herança representada por dois pontos (:){extends e implements}.
    class JogoClasse : MonoBehaviour
    {
       // ...
    }

    // [abstract] Classe ou método.
    abstract class JogoAbstrato 
    {
        // [void] Tipo vazio.
        abstract void metodo();
        // ...
    }

    // [static].
    static class JogoEstatico
    {
        // ...
    }

    // [interface] "Classe" que não implementa métodos.
    interface JogoInterface
    {
       // ...
    }

    // [struct] Tupla ou valores diversos com um identificador.
    struct JogoTupla
    {
       // ...
    }
}
#endregion Classes

#region Primitivos
namespace JogoGrupoTiposPrimitivos
{
    class JogoTiposPrimitivos
    {
        // [enum] Enumeração de valores.
        enum JogoDirecoes
        {
            Norte,
            Sul,
            Leste,
            Oeste
        }

        // [const] Valor constante.
        const constante = 3.14;

        // [bool] (true e false)
        bool boleano = true;

        // [byte] (0 a 255)
        byte num = 255;

        // [sbyte] (-128 a 127 )
        sbyte numS = 127;

        // [int] (-2147483648 a 2147483647)
        int inteiro = 2147483647;

        // [uint] (0 a 4294967295)
        uint inteiroU = 4294967295;

        // [long] (-9223372036854775808 a 9223372036854775807)
        long longo = 9223372036854775807;

        // [ulong] (0 a 18446744073709551615)
        ulong longoU = 18446744073709551615;

        // [short] (-32768 a 32767)
        short curto = 32767;

        // [ushort] (0 a 65535)
        ushort curto = 65535;

        // [float] (-3.402823E+38f a 3.402823E+38f)
        float real = 3.402823E+38f;

        // [double] (-1.79769313486231E+308d a 1.79769313486231E+308d)
        double realDobrado = 1.79769313486231E+308d;

        // [decimal] (7.9228162514264337593543950335m)
        decimal numDecimal = 7.9228162514264337593543950335m;

        // [string] ("teste")
        string texto = "Texto de teste";

        // [char] ('t')
        char letra = 'T';
    }
}
#endregion Primitivos

[delegate] <br>
[new] Instância de objeto <br>
[this] Referência a uma variável da Classe atual <br>
[value] <br>
[return] Retorno de método ou função com tipagem diferente de void <br>
[null] Valor nulo <br>
[var] Variável global <br>
[event] <br>
[internal] <br>
[sealed] <br>
[yield] <br>

### Encapsulamento
[public]
Modificador de acesso aberto <br>

[private]
Modificador de acesso fechado <br>

[protected]
Modificador de acesso aberto apenas para classes herdeiras <br>

[readonly] 
[get]
Propriedade de consulta <br>

[set]
Propriedade modificadora <br>

### Herança
[:]{extends}{Implements}
Herdar e Implementar uma classe pai <br>

### Polimorfismo
**Sobrescrita** <br>
[virtual] <br>
[override] <br>

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

### Estruturas de dados e Lógicos
[if] <br>
[else] <br>
[else_if] <br>
[switch] <br>
[break] <br>
[continue] <br>
[case] <br>
[default] <br>
[for] <br>
[foreach] <br>
[while] <br>
[do_while] <br>

### Coleções
[List] <br>
[ArrayList] <br>
[Dictionary] <br>
[Queue] <br>
[Stack] <br>
[Map] <br>
[LinkedList] <br>

### Funções
[Action] <br>
[Func] <br>

### Tratamento de Exceção
[try] <br>
[catch] <br>
[finally] <br>
[throw] <br>

### Assincronismo
[async] <br>
[await] <br>
[Task] <br>
---
#endregion POO C#


#region Unity Codes
// UNITY CODES


    // EVENT FUNCTIONS
    #region Event Function
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
    #endregion Event Function

    // COMPONENT COMMUNICATION
    #region Communication
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
    #endregion Communication

    // DATA STRUCTURES
    #region Data Structures
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
    #endregion Data Structures

    // INSPECTOR ATTRIBUTES
    #region Inspector
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
    #endregion Inspector

    // DEBUGGING
    #region Debugging
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
    #endregion Debugging

    // NEW INPUT SYSTEM
    #region Input System
    // Setup e configurações
    [SerializeField] InputActionAsset inputAsset;   // Asset reference
    [SerializeField] PlayerInput playerInput;       // Componente de entrada do player
    InputActionMap gameplayMap;                     // Referência de action map
    InputAction moveAction;                         // Ação única

    // Mapas de ação e ligação
    new InputActionMap("GameplayMap");              // Criar map
    action.AddBinding("<Keyboard>/w");              // Ligação basica
    action.AddBinding("<Gamepad>/leftStick");       // Ligação de controle
    action.AddBinding("<Mouse>/delta");             // Ligação de mouse
    action.AddBinding("<Touchscreen>/primaryTouch");// Ligação de touch
    action.AddBinding("<XRController>trigger/");    // Ligação de VR

    // Ligações compostas
    action.AddCompositeBinding("2DVector")          // WASD/Setas
        .With("Up", "<Keyboard>/w")
        .With("Down", "<Keyboard>/s")
        .With("Left", "<Keyboard>/a")
        .With("Right", "<Keyboard>/d");
    
    // Exemplos de sintaxe de caminhos de entradas
    "<Gamepad>/"                                    // Todas as entradas de gamepad
    "<Keyboard>/anyKey"                             // Qualquer entrada de teclado
    "<Mouse>/leftButton"                            // Botões do mouse
    "<XRController>(LeftHand)/trigger"              // Controles VR

    // Lendo valores de entrada
    action.ReadValue<Vector2>();                    // Entrada Vetorial
    action.ReadValue<float>();                      // Entrada Escalonada
    action.IsPressed();                             // Estado do botão
    action.WasPressedThisFrame();                   // Verificação de quadro
    action.WasReleasedThisFrame();                  // Verificação de liberação
    action.IsInProgress();                          // Status de ação

    // Eventos de entrada e retornos de chamada
    action.performed += ctx => { };                 // Desempenho de entrada
    action.started += ctx => { };                   // Entrada iniciada
    action.canceled += ctx => { };                  // Entrada cancelada
    InputSystem.onDeviceChange += (d, c) => { };    // Eventos do dispositivo
    playerInput.onActionTriggered += ctx => { };    // Eventos de entrada de player

    // Tipos de interação
    action.AddBinding().WithInteraction("Tap");     // Pressionada rápida
    action.AddBinding().WithInteraction("Hold");    // Pressiona e segura
    action.AddBinding().WithInteraction("SlowTap"); // Pressionada lenta
    action.AddBinding().WithInteraction("MultiTap");// Múltiplas pressionadas

    // Gerenciamento de dispositivo
    InputSystem.devices;                            // Todos os dispositivos
    Gamepad.all;                                    // Todos os controles
    Gamepad.current;                                // Controles ativos
    InputSystem.EnableDevice(device);               // Dispositivos ativados
    InputSystem.DisableDevice(device);              // Dispositivos desativados

    // Haptic feedback (Tátil, sensível ao toque)
    gamepad.SetMotorSpeeds(leftMotor, rightMotor);  // Vibração
    gamepad.PauseHaptics();                         // Toque em pausa
    gamepad.ResumeHaptics();                        // Toque continuo
    gamepad.ResetHaptics();                         // Parar toque

    // Esquemas de controle
    playerInput.SwitchCurrentControlScheme("Gamepad");// Mudar para controle
    playerInput.currentControlScheme;               // Esquema atual
    playerInput.devices;                            // Dispositivos ativos

    // Configurações de entrada
    InputSystem.settings.updateMode;                // Tempo de atualização
    InputSystem.settings.filterNoiseOnCurrent;      // Filtragem de ruído
    action.processors = "normalize(min=0,max=1)";   // Processamento de entrada

    // Ferramentas de debug
    Debug.Log(action.enabled);                      // Estado da ação
    Debug.Log(action.controls);                     // Controles vinculados
    Debug.Log(InputSystem.devices.Count);           // Contador de dispositivos
    #endregion Input System

    // RENDERING PIPELINE
    #region Render Pipline
    public class RenderPipelineCeaeatSheet : Monobehaviour
    {
        // Configurações de renderização
        Camera.main.renderingPath = RenderingPath.Forward;          // 
        Camera.main.renderingPath = RenderingPath.DeferredShading;  // 
        Camera.main.allowHDR = true;                                // 
        Camera.main.allowNSAA = true;                               // 

        // Configurações de qualidade
        QualitySettings.antiAliasing = 4;                               //
        QualitySettings.softParticles = true;                           //
        QualitySettings.shadows = ShadowQuality.All;                    //
        QualitySettings.shadowResolution = ShadowResolution.VeryHigh;   // 
        QualitySettings.shadowDistance = 150.0f;                        //
        QualitySettings.shadowCascades = 4;                             //

        // Configurações de Luz
        light.renderMode = LightRenderMode.ForcePixel;  // 
        light.shadows = LightShadows.Soft;              // 

        // Sondas de Reflexão
        reflectionProbe.mode = ReflectionProbeMode.Realtime;                // 
        reflectionProbe.resolution = 256;                                   // 
        reflectionProbe.refreshMode = ReflectionProbeRefreshMode.OnAwake;   // 

        // Sondas de Luz
        RenderSettings.ambientMode = AmbientMode.Skybox;    // 
        LightmapSettings.lightProbes.backedProbes = new SphericalHarmonicsL2[backedProbeCount];

        // Configurações de shader
        Shader.globalRenderPipeline = "UniversalPipeline";  // 
        Shader.globalRenderPipeline = "High"                // 
        Shader shader = shader.Find("Custom/MyShader");     // 

        // Configurações de material
        material.enableInstance = true; // 
        material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;

        // GPU Instanceing
        Graphics.DrawMeshInstanced(mesh, 0, material, matrices);
        Graphics.DrawProceduralNow(MeshTopology.Triangles, 36);

        // LOD (Level of Detail) System
        lodGroup.SetLODs(new LOD[] {
            new LOD(0.6f, renderers),
            new LOD(0.3f, renderers),
            new LOD(0.1f, renderers)
        })
    }
    #endregion Render Pipline

    // ANIMATIONS
    #region Animations
    public class UnityAnimation : Monobehaviour
    {
        // Controle de parâmetros do Animator
        animator.SetBool("isRunning", true);
        animator.SetFloat("speed", speedValue);
        animator.SetInteger("state", stateValue);
        animator.SetTrigger("jump");
        animator.ResetTrigger("jump");

        // Otimização de performance
        int runHash = Animator.StringToHash("isRunning");
        animator.SetBool(runHash, true);

        // Playback control
        animator.Play("RunAnimator");
        animator.CrossFade("WalkAnimation", fadeDuration);
        animator.PlayInFixedTime("IdleAnimation", 0);
        animator.StopPlayback();

        // Informações de estado
        animator.IsIntransition(layerIndex);
        animator.GetCurrentAnimatorStateInfo(layerIndex);
        animator.GetNextAnimatorStateInfo(layerIndex);
        animator.GetCurrentAnimatorClipInfo(layerIndex);
        animator.Rebind();
        animator.Update(deltaTime);

        // Controle de Layer
        animator.SetLayerWeight(layerIndex, weight);
        animator.GetLayerWeight(layerIndex);
        animator.GetLayerName(layerIndex);
        animator.GetLayerIndex("UpperBody");

        // Propriedades do Animator
        animator.applyRootMotion = true;
        animator.bodyPosition = newPosition;
        animator.bodyRotation = newRotation;
        animator.updateMode = AnimatorUpdateMode.AnimatePhysics;
        animator.stabilizeFeet = true;

        // Animation Events
        AnimationEvent event = new AnimationEvent
        {
            functionName = "OnAnimetionEnd",
            floatParameter = keyValue,
            intParameter = 1,
            stringParameter = "completed",
            time = eventTime
        }

        // Animation Curves
        AnimationCurve.Linear(startTime, startValue, endTime, endValue);
        AnimationCurve.EaseInOut(starTime, startValue, endTime, endValue);
        AnimationCurve.AddKey(curveTime, keyValue);
        AnimationCurve.RemoveKey(keyIndex);
        AnimationCurve.MoveKey(keyIndex, newKey);
        float value = animationCurve.Evaluate(time);
    }
    #endregion Animations

    // AI: NAVMESH AGENT
    #region NavigationAI
    public class UnityNavigationAI : MonoBehaviour
    {
        // Controle de movimento do agente
        agent.SetDestination(targetPosition);
        agent.isStopped = true;
        agent.speed = 3.5f;
        agent.angularSpeed = 120f;
        agent.acceleration = 8f;
        agent.ResetPath();
        agent.velocity = new Vector3(0, 0, 3);
        agent.Move(Vector3.forward * 5);
        agent.radius = 0.5f;

        // Informações de estado do agente
    }
    #endregion NavigationAI

    // UI
    #region UI
    public class UnityUI : MonoBehaviour
    {
        // Canvas Control
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.worldCamera = mainCamera;
        canvas.pixelPerfect = true;
        canvas.sortingOrder = 5;
        canvasGroup.alpha = 0.8f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = true;

        // RectTransform Control === Controle de transformação de retângulo
        rectTransform.anchoredPosition = new Vector2(0, 50);
        rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        rectTransform.offsetMin = new Vector2(10, 10);
        rectTransform.offsetMax = new Vector2(-10, -10);
        rectTransform.sizeDelta = = new Vector2(200, 100);
        rectTransform.pivot = new Vector2(0.5f, 0.5f);

        // TextMeshPro Control
        tmpText.text = "Welcome to Unity!";
        tmpText.fontSize = 30;
        tmpText.alignment = TextAlignmentOptions.Center;
        tmpText.color = Color.green;

        // RawImage Control
        rawImage.texture = texture;
        rawImage.color = Color.white;
        rawImage.uvRect = new RenderPipelineCeaeatSheet(0, 0, 1, 1);

        // Button Control
        button.onClick.AddListener(OnButtonClick);
        button.interactable = true;

        // Image Control
        image.sprite = mySprite;
        image.color = Color.blue;
        image.fillAmount = 0.5f;

        // Slider Control
        slider.value = 0.75f;
        slider.minValue = 0;
        slider.maxValue = 1;
        slider.onValueChanged.AddListener(OnSliderValueChanged);

        // Toggle Control
        toggle.isOn = true;
        toggle.onValueChanged.AddListener(OnToggleChanged);

        // ScrollRect Control
        scrollRect.content = contentTransform;
        scrollRect.vertical = true;
        scrollRect.horizontal = false;
        scrollRect.normalizedPosition = new Vector2(0.5f, 0.5f);

        // InputField Control
        inputField.text = "Type here";
        inputField.onValueChanged.AddListener(OnInputValueChanged);
        inputField.onEndEdit.AddListener(OnInputEndEdit);

        // Dropdown Control
        dropdown.options = dropdownOptions;
        dropdown.value = 2;
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);

        // Event System
        EventSystem.current.SetSelectedGameObject(button.gameObject);
        EventSystem.current.currentSelectedGameObject;
        EventSystem.current.sendNavigationEvents = true;
        EventSystem.current.UpdateModules();
        EventSystem.current.IsPointerOverGamoObject();
        EventSystem.current.BaycastAll(pointEventData, raycastResults);
    }
    #endregion UI

    // COLLISIONS
    #region Collisions
    public class UnityCollisions : MonoBehaviour
    {
        // General Collider Propierties
        collider.enabled = true;
        collider.isTrigger = false;
        Bounds bounds = collider.bounds;
        collider.material = physicMaterial;
        collider.sharedMaterial = sharedPhysicMaterial;
        collider.contactOffset = 0.01f;

        // BoxColider Propierties
        boxCollider.size = new Vector3(2, 2, 2);
        boxCollider.center = new Vector3(0, 1, 0);

        // SphereCollider Propierties
        sphereCollider.radius = 1.5f;
        sphereCollider.center = new Vector3(0, 1, 0);

        // CapsuleCollider Propierties
        capsuleCollider.height = 2.5f;
        capsuleCollider.radius = 0.5f;
        capsuleCollider.direction = 1;

        // MeshCollider Propierties
        meshCollider.sharedMesh = mesh;
        meshCollider.convex = true;
        meshCollider.cookingOptions = MeshColliderCookingOptions.None;

        // TerrainCollider Propierties
        terrainCollider.terrainData = terrainData;
        terrainCollider.bounds.Encapsulate(Vector3.one);

        // WheelCollider Propierties
        wheelCollider.motorTorque = 100f;
        wheelCollider.steerAngle = 30f;
        wheelCollider.brakeTorque = 500f;
        wheelCollider.suspensionSpring = new JointSpring
        {
            spring = 1000f,
            damper = 500f,
            targetPosition = 0.5f
        };

        // Collision Events
        void OnCollisionEnter(Collision collision) {}
        void OnCollisionStay(Collision collision) {}
        void OnCollisionExit(Collision collision) {}
        void OnTriggerEnter(Collider other) {}
        void OnTriggerStay(Collider other) {}
        void OnTriggerExit(Collider other) {}

        // Physics Interaction Methods
        Physics.IgnoreCollision(collider1, collider2, true);
        Physics.IgnoreLayerCollision(3, 5, true);
        Physics.Raycast(origin, direction, out hit, maxDistance);
        Collider[] overlappingColliders = Physics.OverlapSphere(
            transform.position, radius
        );

        // Advanced Physics Methods
        Physics.BoxCast(
            transform.position, boxHalfExtends, direction
        );
        Physics.SphereCast(
            new Ray(transform.position, direction),
            radius,
            masDistance
        );
        Physics.CapsuleCast(
            point1, point2, radius, direction
        );
        Physics.RaycastAll(
            transform.position, transform.forward
        );
        Physics.RaycastNonAlloc(
            transform.position, transform.forward, results, maxDistance
        );
        Physics.OverlapBox(
            transform.position, boxHalfExtents
        );
        Physics.OverlapCapsule(
            point1, point2, radius
        );

        // Collision Data
        Vector3 relativeVelocity = collision.relativeVelocity;
        ContactPoint[] contacts = collision.contacts;
        Vector3 contactNormal = contacts[0].normal;
        Vector3 contactPoint = contacts[0].point;
        Vector3 impulse = collision.impulse;
        Collider closeCollider = collider.ClosesPoint(
            targetPosition
        );
        GameObject colliderObject = collision.gameObject;
    }
    #endregion Collisions

    // CÂMERA
    #region Camera
    public class UnityCameraSystem : MonoBehaviour
    {
        // General Camera Propierties
        camera.fieldOfView = 60f;
        camera.orthographic = false;
        camera.orthographicSize = 5f;
        camera.aspect = 16f / 9f;
        camera.nearClipPlane = 0.3f;
        camera.farClipPlane = 1000f;
        camera.depth = -1;
        camera.cullingMask = LayerMaskGetMask("Default");
        camera.backgoundColor = Color.black;
        camera.clearFlags = CameraClearFlag.Skybox;

        // Rendering and Effects
        camera.allowHDR = true;
        camera.allowMSAA = true;
        camera.renderingPath = RenderingPath.DeferredShading;
        camera.targetTexture = renderTexture;
        camera.depthTextureMode = DepthTextureModed.DepthNormals;

        // Camera Transformations
        Vector3 screenPoint = camera.WorldToScreenPoint(worldPosition);
        Vector3 worldPoint = camera.ScreenToWorldPoint(screenPosition);
        Vector3 viewportPoint = camera.ScreenToViewportPoint(screenPosition);
        Vector3 rayDirection = camera.ScreenPointToRay(screenPosition).direction;

        // Camera Physical Propierties
        camera.usePhysicalPropierties = true;
        camera.focalLength = 50f;
        camera.sensorSize = new Vector2(36f, 24f);
        camera.lensShift = new Vector2(0f, 0f);
        camera.gateFit = Camera.GateFitMode.Horizontal;

        // Multi-Display Settings
        camera.targetDisplay = 0;
        Camera. SetupCurrent(camera);

        // Gizmos and Debugging
        Gizmos.DrawFrustum(
            camera.transform.position,
            camera.fieldOfView,
            camera.farClipPlane,
            camera.nearClipPlane,
            camera.aspect
        );

        // Camera Events
        void OnPreCull() {}
        void OnPreRender() {}
        void OnPostRender() {}

        // Multi-Pass and Custom Renders
        camera.AddCommandBuffer(CameraEvent.AfterImageEffects, commandBuffer);
        camera.RemoveCommandBuffer(CameraEvent.AfterImageEffects, commandBuffer);
    }
    #endregion Camera
#endregion Unity Codes
