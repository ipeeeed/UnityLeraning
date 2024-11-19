using System;
using UnityEngine;

/// <summary>
/// Delegate armazena um método para ser usado como variável.
/// Exemplo: single-cast
/// </summary>
public class DelegateExample : MonoBehaviour
{
    // public delegate void MyDelegate(string name);
    public delegate void MyDelegate();
    public static MyDelegate myDelegate;

    // private void Start() {
    //     myDelegate = DebugName;
    //     myDelegate("Pedro");
    // }

    // private void DebugName(string name)
    // {
    //     Debug.Log(name);
    // }
}
