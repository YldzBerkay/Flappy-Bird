using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    [SerializeField] Text startHighScoreAndinPlay;
    [SerializeField] Text deadScore;
    [SerializeField] Text deadHighScore;

    [SerializeField] GameObject[] Awards;

    private void Awake()
    {
        startHighScoreAndinPlay.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        high = PlayerPrefs.GetInt("highScore", 0);
    }

    int score,high;
    void Update()
    {
        high = PlayerPrefs.GetInt("highScore", 0);
        score = countScore.point;
        highScore();
        
        deadScore.text = score.ToString();
        
        if(GameStart.gameStarted==false)
            startHighScoreAndinPlay.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        else
            startHighScoreAndinPlay.text = score.ToString();

        deadHighScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();

        if (score < 50)
        {
            Awards[0].SetActive(true);
            Awards[1].SetActive(false);
        }
        else
        {
            Awards[1].SetActive(true);
            Awards[0].SetActive(false);
        }
    }

    void highScore()
    {
        if (high < score)
        {
            high = score;
            PlayerPrefs.SetInt("highScore", high);

        }
    }
}
