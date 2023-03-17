using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;

    [SerializeField] Text countdownText;

    [SerializeField] Text GameOverText;

    // Start is called before the first frame update
    void Start()
    {
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
            //Stop the game movement animations
            Time.timeScale = 0f;


        }
    }

    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
    }
   }