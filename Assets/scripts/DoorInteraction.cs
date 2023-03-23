using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{

    [SerializeField] GameObject Doors;

    bool isActivated = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interact()
    {
        if (!isActivated)
        {
            isActivated = true;
            Doors.transform.position += new Vector3(0, -100, 0);
            Debug.Log("Door Interact!");
        }
    }
}