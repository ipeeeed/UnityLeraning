using UnityEngine;

public class Sobrecarga : MonoBehaviour
{
    public int Add(int num1, int num2) {


        return num1 + num2;
    }

    public int Add(int num1) {


        return num1;
    }

    public string Add(string str1, string str2) {


        return str1 + " " + str2;
    }
}
