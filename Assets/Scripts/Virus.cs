using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag is "Virus")
        {
            if (other.CompareTag("Border"))
            {
                Destroy(this.gameObject);
            } else if (other.CompareTag("Player"))
            {
                Destroy(other.gameObject);
            } else if (other.CompareTag("Mask"))
            {
                Destroy(this.gameObject);
                other.gameObject.SetActive(false);
            }
        } else if (gameObject.tag is "PowerUp")
        {
            if (other.CompareTag("Player"))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
