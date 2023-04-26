using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    float currentTime = 30;
    public TextMeshProUGUI countDown;

    public void Update()
    {
        currentTime = currentTime - 1 * Time.deltaTime;
        countDown.text = currentTime.ToString();

        if (currentTime <= -0.1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

}
