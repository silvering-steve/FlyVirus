using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public GameObject mask;
    
    private Rigidbody2D _rb;
    private Vector2 _playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        _playerDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(0, _playerDirection.y * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerUp"))
        {
            mask.SetActive(true);
        }
    }
}
