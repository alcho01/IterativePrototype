using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour
{
    PlayerControls controls;

    float currentTime = 0f;
    float startingTime = 70f;

    [SerializeField] Image InstructionsReset;

    [SerializeField] Text countdownText;

    [SerializeField] Image BackgroundImage;

    [SerializeField] Text GameOverText;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Reset.performed += ctx => ResetOn();


    }

    // Start is called before the first frame update
    void Start()
    {
        InstructionsReset.gameObject.SetActive(false);
        BackgroundImage.gameObject.SetActive(false);
        GameOverText.gameObject.SetActive(false);
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Start Counting down in seconds rather than frames
        currentTime -= 1 * Time.deltaTime;
        //Ignore Decimals 
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            //Call the Game Over Function
            GameOver();
            //Stop the game movement animation


        }
    }

    void ResetOn()
    {
        if (currentTime <= 0)
        {
            currentTime = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void GameOver()
    {
        InstructionsReset.gameObject.SetActive(true);
        BackgroundImage.gameObject.SetActive(true);
        GameOverText.gameObject.SetActive(true);
        
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