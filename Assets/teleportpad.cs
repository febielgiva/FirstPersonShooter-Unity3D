using UnityEngine;
using System.Collections;

public class teleportpad : MonoBehaviour {
    public Transform target;
    void onTriggerEnter(Collider collider)
    {
       
            Destroy(collider.gameObject);
        /*
        if (collider.gameObject.tag == "teleporter1")
        {
            Debug.LogError("comes in");
            //Vector3 teleportedPosition = new Vector3(10.6f, 2.71f, 13.3f);
            this.transform.position = target.position;
            //Vector3 teleportedPosition = new Vector3(35.1f, 5f, 64.9f);
            //collider.gameObject.transform.position = teleportedPosition;
        }
        */
    }
}
