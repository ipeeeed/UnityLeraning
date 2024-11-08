using UnityEngine;

public class GetComponents : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody rig;
    public BoxCollider box;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();

        //obj.SetActive(false);
        //obj.GetComponent<BoxCollider>().enabled = false;

        if (obj.activeSelf) {
            obj.SetActive(false);
            Debug.Log(obj.activeSelf);
        } else {
            obj.SetActive(true);
            Debug.Log(obj.activeSelf);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
