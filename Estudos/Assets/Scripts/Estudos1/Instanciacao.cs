using UnityEngine;

public class Instaciacao : MonoBehaviour
{
    public GameObject prefab;
    //public GameObject camera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            //Instantiate(prefab, camera.transform.position, camera.transform.rotation);
            //Instantiate(prefab, transform.position, transform.rotation);
            Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
