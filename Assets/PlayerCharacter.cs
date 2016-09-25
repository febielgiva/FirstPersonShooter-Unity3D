using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {
	private int _health;
    public Transform target1;
    public Transform target2;

    void Start() {
		_health = 5;
	}

	public void Hurt(int damage) {
		_health -= damage;
		Debug.Log("Health: " + _health);
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "teleporter1")
        {
            this.transform.position = target1.position;
        }
        else
        if (collider.gameObject.tag == "teleporter2")
        {
            this.transform.position = target2.position;
        }
    }
}
