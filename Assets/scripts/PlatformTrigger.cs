using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    [SerializeField] GameObject DarkPlatforms;

    bool isActivated = false;


    private void OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            if (!isActivated)
            {
                isActivated = true;
                DarkPlatforms.transform.position += new Vector3(0, 6, 0);
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
