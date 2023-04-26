using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public AudioSource endClick;
    public void Quit()
    {
        Application.Quit();
        endClick.Play();
    }
}
