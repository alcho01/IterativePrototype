using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeInteraction : MonoBehaviour
{

    [SerializeField] GameObject IceBlocks;

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
            IceBlocks.transform.position += new Vector3(0, 12, 0);
            Debug.Log("Fridge Interact!");
        }
    }
}
