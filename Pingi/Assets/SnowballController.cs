using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballController : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        int randomNumber = Random.Range(7, 16);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-randomNumber, 1f), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
