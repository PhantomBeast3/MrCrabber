using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public float deadZone = -10f;
    public LogicScript logic;
    public AudioSource collect;

    void Start()
    {
      logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            
            logic.addScore(1);
        }


        if (transform.position.y < deadZone || collision.gameObject.layer == 3)
        {
            Destroy(gameObject);
        }


    }

}
