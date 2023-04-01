using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathDisplayer : MonoBehaviour
{

    public GameObject myLight;


    // Start is called before the first frame update
    void Start()
    {
        myLight.GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            myLight.GetComponent<Light>().enabled = true;
        }
    }
}