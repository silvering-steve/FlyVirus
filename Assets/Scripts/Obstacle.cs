using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject shield;

    public float maxX;
    public float maxY;
    public float minX;
    public float minY;

    public float timeBetweenSpawn;
    public float timeBetweenShield;

    private float _spawnTime;
    private float _shieldTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _shieldTime)
        {
            Spawn(shield);
            _shieldTime = Time.time + timeBetweenShield;
        }
        
        if (Time.time > _spawnTime)
        {
            Spawn(obstacle);
            _spawnTime = Time.time + timeBetweenSpawn;
        }
        
        //Difficulty
        ScallingDifficulty();
    }

    void Spawn(GameObject gameObject)
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(gameObject, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    public void ScallingDifficulty()
    {
        if (GlobalVar.Score < 10)
        {
            timeBetweenSpawn = (float) 1;
        } else if (GlobalVar.Score < 20 && GlobalVar.Score > 10)
        {
            timeBetweenSpawn = (float) 0.8;
        }else if (GlobalVar.Score < 30 && GlobalVar.Score > 20)
        {
            timeBetweenSpawn = (float) 0.6;
        }else if (GlobalVar.Score < 40 && GlobalVar.Score > 30)
        {
            timeBetweenSpawn = (float) 0.4;
        }
    }
}
