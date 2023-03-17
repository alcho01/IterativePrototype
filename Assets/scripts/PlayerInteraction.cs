using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] Text LevelCompleteText;

    void Start()
    {
        LevelCompleteText.gameObject.SetActive(false);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere (transform.position, interactRange);
            foreach(Collider collider in colliderArray) {

                if (collider.TryGetComponent(out FridgeInteraction fridgeInteraction))
                {

          
                    fridgeInteraction.Interact();
                }

                if (collider.TryGetComponent(out StoveInteraction stoveInteraction)) {
                    stoveInteraction.Interact();

                    LevelComplete();
                    Time.timeScale = 0f;
                }

               
            }
        }
    }

    public void LevelComplete()
    {
        LevelCompleteText.gameObject.SetActive(true);
    }
}
