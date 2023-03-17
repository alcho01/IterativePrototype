using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2Trigger : MonoBehaviour
{
    [SerializeField] GameObject LightPlatforms;

    bool isActivated = false;


    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            if (!isActivated)
            {
                isActivated = true;
                LightPlatforms.transform.position += new Vector3(0, 11.8f, 0);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}