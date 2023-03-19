using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    PlayerControls controls;

    [SerializeField] Text LevelCompleteText;


    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Interact.performed += ctx => InteractionOn();
    }

    void Start()
    {
        LevelCompleteText.gameObject.SetActive(false);
    }

    void Update() {

    }

    void InteractionOn()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {

            if (collider.TryGetComponent(out FridgeInteraction fridgeInteraction))
            {


                fridgeInteraction.Interact();
            }

            if (collider.TryGetComponent(out StoveInteraction stoveInteraction))
            {
                stoveInteraction.Interact();

                LevelComplete();
                Time.timeScale = 0f;
            }
        }
    }

    public void LevelComplete()
    {
        LevelCompleteText.gameObject.SetActive(true);
    }

    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable(); 
    }
}
