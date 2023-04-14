using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    PlayerControls controls;


    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Interact.performed += ctx => InteractionOn();
    }

    void Start()
    {

    }

    void Update()
    {

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

            if (collider.TryGetComponent(out DoorInteraction doorInteraction))
            {


                doorInteraction.Interact();

            }

            if (collider.TryGetComponent(out StoveInteraction stoveInteraction))
            {
                stoveInteraction.Interact();

                LevelComplete();

            }
        }
    }

    public void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
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