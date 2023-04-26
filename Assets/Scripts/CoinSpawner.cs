using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public float spawnRate = 1;
    public float timer = 0f;
    public float length = 10f;

    void Start()
    {
        
    }

    
    void Update()
    {
        float lowPoint = transform.position.x - length;
        float highPoint = transform.position.x + length;

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(coin, new Vector3(Random.Range(highPoint,lowPoint),transform.position.y, 0), transform.rotation);
            timer = 0;
        }


    }
}
