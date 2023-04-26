using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    

    public void addScore(int scoreAdd)
    {
        playerScore = playerScore + scoreAdd;
        scoreText.text = playerScore.ToString();
    }
}
