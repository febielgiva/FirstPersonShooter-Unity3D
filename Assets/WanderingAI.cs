using UnityEngine;
using System.Collections;

public class WanderingAI : MonoBehaviour {
	public float speed = 2.0f;
	public float obstacleRange = 5.0f;

    [SerializeField] private GameObject fireballPrefab;
	private GameObject _fireball;
	
	private bool _alive;
    //public Transform Player; //
    int MinDist =15; //
    int MaxDist = 30; //
    public int MoveSpeed = 2;
    Transform target;
    Transform myTransform;
    public int rotationSpeed = 2;
    float lifetime = 2.0f;


    void Start() {
		_alive = true;
        target = GameObject.FindWithTag("Player").transform;
    }

    void Awake()
    {
        myTransform = transform;
    }

    void Update()
    {

        if (_alive)
        {
            /*
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
            Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            //move towards the player
            myTransform.position += myTransform.forward * MoveSpeed * Time.deltaTime;*/


            transform.LookAt(target);

            if (Vector3.Distance(transform.position, target.position) >= MinDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                if (Vector3.Distance(transform.position, target.position) <= MaxDist)
                {

                    transform.Translate(0, 0, speed * Time.deltaTime);

                    Ray ray = new Ray(transform.position, transform.forward);
                    RaycastHit hit;
                    if (Physics.SphereCast(ray, 0.75f, out hit))
                    {
                        GameObject hitObject = hit.transform.gameObject;
                        if (hitObject.GetComponent<PlayerCharacter>())
                        {

                            _fireball = Instantiate(fireballPrefab) as GameObject;
                            _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                            _fireball.transform.rotation = transform.rotation;
                            Destroy(_fireball, lifetime);

                        }

                        //transform.Rotate(0, speed, 0)
                        else if (hit.distance < obstacleRange)
                        {
                            float angle = Random.Range(-110, 110);
                            transform.Rotate(0, angle, 0);
                        }
                    }
                }
            }
        }
        }
	public void SetAlive(bool alive) {
		_alive = alive;
	}
}
