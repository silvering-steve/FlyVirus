using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            GlobalVar.Score += 1 * Time.deltaTime;
            scoreText.text = ((int) GlobalVar.Score).ToString();
        }
    }
}
