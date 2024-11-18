// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Variaveis : MonoBehaviour
// {
//     // Comentarios de uma linha.

//     /* 
// 	 * Comentarios com mais de uma linha.
// 	 * Comentarios com mais de uma linha.
// 	 * Comentarios com mais de uma linha.
// 	*/

//     public byte binario = 255; // sbyte = -128/127, byte = 0/255
//     public int inteiro = 2147483647; // int = -2147483648/2147483647, uint = 0/4294967295
//     public long inteiroLongo = 9223372036854775807; // long = -9223372036854775808/9223372036854775807, ulong = 0/18446744073709551615
//     public short inteiroCurto = 32767; // short = -32768/32767, ushort = 0/65535
//     public float realCurto = 3.402823E+38f; // float = -3.402823E+38/3.402823E+38
//     public double realMedio = 1.79769313486231E+308d; // double = -1.79769313486231E+308d/1.79769313486231E+308d
//     public decimal realLongo = 7.9228162514264337593543950335m;
//     public string texto = "teste";
//     public char caractere = 't';
//     public bool boleano = true;

//     public int[] array = {1, 2, 3, 4, 5};
//     public List<int> listaInteiros = new List<int>();
//     public Dictionary<int, string> dicionario = new Dictionary<int, string>(); // Dicionário<Chave, valor>();

//     public struct estrutura {
//         public int num;
//         public string txt;
//         public bool VouF;
//     }

//     public GameObject gameObject;
//     public Transform transform;
//     public Rigidbody rig;
//     public BoxCollider box;

//     //private void Start()
//     //{
//     //	Estaticos.estaticos.AumentarVida();
//     //	Debug.Log("Seu total de Vidas e: " + Estaticos.estaticos.vidas);
//     //}

//     void Start() {
//         for (int i = 0; i < 5; i++)
//         {
//             listaInteiros.Add(i);
//         }

//         dicionario.Add(1, "Primeira Chave");
//         dicionario.Add(2, "Segunda Chave");
//         dicionario.Add(3, "Terceira Chave");
//     }
// }
