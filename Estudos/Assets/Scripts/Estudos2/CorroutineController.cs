using System.Collections;
using UnityEngine;

public class CorroutineController : MonoBehaviour {
    void Start() {
        StartCoroutine("Test");
    }

    IEnumerator Test() {
        // Debug.Log("Executando corrotina antes");
        // yield return new WaitForSeconds(3f);
        // Debug.Log("Executando corrotina depois");
        int i = 1;

        while (i <= 10)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log(i + " segundos");
            i++;
        }
    }
}