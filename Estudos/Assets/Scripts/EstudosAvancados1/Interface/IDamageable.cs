using UnityEngine;

/// <summary>
/// É um conjunto de métodos, propriedades que uma classe destino deve implementar
/// É um tipo de classe que contém apenas assinaturas de métodos e propriedades
/// Ajuda a organizar o código, permitindo a criação de código mais flexível
/// Para implementar, chama-se a interface após o : da classe. Ex: public class Player : IDamageable
/// Padrão de nomeclaturas: inicia-se o nome com I
/// </summary>
public interface IDamageable
{
    int currentHealth { get; }
    void ApplyDamage(int damage);
}
