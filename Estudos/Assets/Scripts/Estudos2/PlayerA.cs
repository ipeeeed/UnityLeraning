using UnityEngine;

public class PlayerA : MonoBehaviour
{
    private int exp;
    
    // public int Experience { get; set;}
    public int Experience {
        get
        {
            return exp;
        }
        set
        {
            exp = value;
        }
    }
}
