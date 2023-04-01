using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointAppear : MonoBehaviour
{
    [SerializeField] GameObject Flags;

    bool isActivated = false;

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            if (!isActivated)
            {
                isActivated = true;
                Flags.transform.position += new Vector3(0, 10f, 0);
                Debug.Log("Checkpoint Reached!");
            }
        }
    }
}
