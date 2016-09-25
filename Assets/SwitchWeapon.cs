using UnityEngine;
using System.Collections;

public class SwitchWeapon : MonoBehaviour {

    public GameObject weapon01;
    public GameObject weapon02;


    // Use this for initialization
    void Start()
    {
        weapon01.SetActive(true);
        weapon02.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (weapon01.activeSelf)
            {
                weapon01.SetActive(false);
                weapon02.SetActive(true);
            }
            else
            {
                weapon01.SetActive(true);
                weapon02.SetActive(false);
            }
        }

    }
}
