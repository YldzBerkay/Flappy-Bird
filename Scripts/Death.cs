using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] GameObject DeathPanel;


    void Update()
    {
        if (Player.gameOver == true)
        {
            Time.timeScale = 0;

            DeathPanel.SetActive(true);

        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
