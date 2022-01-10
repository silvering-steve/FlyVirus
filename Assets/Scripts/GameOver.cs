using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TextMeshProUGUI hiScore;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") is null)
        {
            if (GlobalVar.Score > GlobalVar.HighScore)
            {
                GlobalVar.HighScore = GlobalVar.Score;
            }

            hiScore.text = "Highscore : " + ((int) GlobalVar.HighScore).ToString();
            
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        GlobalVar.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
