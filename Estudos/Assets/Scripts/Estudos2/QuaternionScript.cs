using UnityEngine;

public class QuaternionScript : MonoBehaviour
{
    public Transform target;
    public Transform anotherObject;
    public float timeCount = 0f;
    
    void Start()
    {
        Debug.Log(Quaternion.identity)
;    }

    void Update()
    {
        // Vector3 Pos = target.position - transform.position;
        // transform.rotation = Quaternion.LookRotation(Pos);

        transform.rotation = Quaternion.Slerp(target.rotation, anotherObject.rotation, timeCount);
        timeCount = timeCount + Time.deltaTime;

        // Quaternion.EulerAngles(1,1,1); // Não está funcionando
    }
}
