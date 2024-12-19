# `Unity`
## Orientação a Objetos
### [C#][Java]
---
[using][import] <br>
[namespace][package] <br> <!-- Se comportam de maneiras parecidas, mas [package] é predefinido de acordo com o esquema de pasta e [namespace] é definido pelo próprio desenvolvedor -->
[class] <br> <!-- Modelo de Objeto -->
[interface] <br> <!-- "Classe" que não implementa métodos -->
[struct] <br> <!-- Tupla ou valores diversos com um identificador -->
[static] <br>
[delegate] <br>
[new] <br> <!-- Instância de objeto -->
[this] <br> <!-- Referência a uma variável da Classe atual -->
[value] <br> <!-- ?????? -->
[return] <br> <!-- Retorno de método ou função com tipagem diferente de void -->
[null] <br> <!-- Valor nulo -->
[var] <br> <!-- Variável global -->
[event] <br>
[internal] <br>
[sealed] <br>
[yield] <br>
---
### Abstração
[abstract] <br>
---
### Encapsulamento
[public] <br> <!-- Modificador de acesso aberto -->
[private] <br> <!-- Modificador de acesso fechado -->
[protected] <br> <!-- Modificador de acesso aberto apenas para classes herdeiras -->
[readonly] <br>
[get] <br> <!-- Propriedade de consulta -->
[set] <br> <!-- Propriedade modificadora -->
---
### Herança
[:][extends] <br> <!-- Herdar de uma classe pai -->
[:][implemenst] <br> <!-- Implementar uma classe pai -->
---
### Polimorfismo
**Sobrescrita** <br>
[virtual] <br>
[override][@Override] <br>
---
**Sobrecarga** <br>
`Quando o mesmo metodo tem tipos ou assinaturas diferentes`
``` c#
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
[x]<br>
---
### Tipos primitivos
[void] <br> <!-- Tipo vazio -->
[const] <br> <!-- Valor constante -->
[enum] <br> <!-- Enumeração de valores -->
---
[bool] <br> <!-- true e false -->
[byte] <br> <!-- 0 a 255 -->
[sbyte] <br> <!-- -128 a 127  -->
[int] <br> <!-- -2147483648 a 2147483647 -->
[uint] <br> <!-- 0 a 4294967295 -->
[long] <br> <!-- -9223372036854775808 a 9223372036854775807 -->
[ulong] <br> <!-- 0 a 18446744073709551615 -->
[short] <br> <!-- -32768 a 32767 -->
[ushort] <br> <!-- 0 a 65535 -->
[float] <br> <!-- -3.402823E+38 a 3.402823E+38 -->
[double] <br> <!-- -1.79769313486231E+308d a 1.79769313486231E+308d -->
[decimal] <br> <!-- 7.9228162514264337593543950335m -->
[string][String] <br> <!-- "teste" -->
[char] <br> <!-- 't' -->
---
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
---
### Coleções
[List] <br>
[ArrayList] <br>
[Dictionary] <br>
[Queue] <br>
[Stack] <br>
[Map] <br>
[LinkedList] <br>
---
### Funções
[Action] <br>
[Func] <br>
---
### Tratamento de Exceção
[try] <br>
[catch] <br>
[finally] <br>
[throw] <br>
---
### Assincronismo
[async] <br>
[await] <br>
[Task] <br>
---
### Event Functions
``` C#
    // Inicialização e Ciclo de Vida
    void Awake(){}      // 1º: Configurações principais e referências
    void OnEnable(){}   // Quando o objeto/componente ativa
    void Start(){}      // Antes do primeiro frame, depois do Awake()
    void OnDisable(){}  // Quando o objeto/componente desativa
    void OnDestroy(){}  // Limpeza final antes de destruir

    // Atualizações e Repetições (loops)
    void Update(){}     // A cada frame - toda a logica do main game
    void FixedUpdate(){}// Intervalo de tempo fixo - física apenas
    void LateUpdate(){} // Depois da atualizações - cameras e ajustes finais

    // Físicas e Colisões
    void OnCollisionEnter(Collision other){}    // Primeiro toque
    void OnCollisionStay(Collision other){}     // Durante o toque
    void OnCollisionExit(Collision other){}     // Após o toque
    void OnTriggerEnter(Collision other){}      // Entrando na zona de acionamento
    void OnTriggerStay(Collision other){}       // Dentro da zona de acionamento
    void OnTriggerExit(Collision other){}       // Ao sair da zona de acionamento

    // Renderização e Visibilidade
    void OnBecameVisible(){}    // Objeto entra em qualquer visualização de câmera
    void OnBecameInvisible(){}  // Objeto sai de todas as visualizações de câmera
    void OnRenderObject(){}     // Após acamera renderizar a cena
    void OnWillRenderObject(){} // Antes de cada renderização de câmera
    void OnGUI(){}              // IMGUI renderização

    // Aplicações de Fluxos
    void OnAplicationFocus(bool focus){}    // Mudança de foco da janela
    void OnAplicationPause(bool pause){}    // App pausa/continua
    void OnAplicationQuit(){}               // Antes do app fechar

    // Entrada e Interação
    void OnMouseEnter(){}
    void OnMouseOver(){}
    void OnMouseExit(){}
    void OnMouseDown(){}
    void OnMouseUp(){}
    void OnMouseDrag(){}

    // Editor e Desenvolvimento
    void 
```
