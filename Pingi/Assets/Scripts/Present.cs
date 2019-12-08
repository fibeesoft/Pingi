using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{
    [SerializeField] Sprite[] presents;
    SpriteRenderer presentSprite;
    Rigidbody2D rb;
    float speed = 23f;
    void Start()
    {
        presentSprite = GetComponentInChildren<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        int randomNumber = Random.Range(0, presents.Length);
        presentSprite.sprite = presents[randomNumber];
        rb.AddForce(new Vector2(0.6f * speed, 1.2f * speed), ForceMode2D.Impulse);
    }

}
