using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;

    bool isOpened = false;

    void Start()
    {

    }

    void OnTriggerEnter(Collider Player)
    {
        
        if (Player.tag == "Player")
        {

            if (!isOpened)
            {
                isOpened = true;
                door.transform.position += new Vector3(0, 4, 0);
            }
        }
    }
}
