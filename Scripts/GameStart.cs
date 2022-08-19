using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] GameObject[] StartCanva;

    public static bool gameStarted;
    
    void Awake()
    {
        Player.gameOver = false;
        countScore.point = 0;
        gameStarted = false;
        Time.timeScale = 0f;
        for (int i = 0; i < StartCanva.Length; i++)
            StartCanva[i].SetActive(true);
    }


    void Update()
    {
        isGameStarted();
    }

    public void PlayGame()
    {
        gameStarted = true;
    }

    void isGameStarted()
    {
        if (gameStarted == true)
        {
            for (int i = 0; i < StartCanva.Length; i++)
                StartCanva[i].SetActive(false);

            Time.timeScale = 1f;
        }
        else if(gameStarted == false)
        {
            for (int i = 0; i < StartCanva.Length; i++)
                StartCanva[i].SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
