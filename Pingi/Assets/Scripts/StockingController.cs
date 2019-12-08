using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockingController : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] SpriteRenderer stockingSprite;

    float speed, maxAngle;
    void Start()
    {
        int randomNumber = Random.Range(0, sprites.Length);
        stockingSprite.sprite = sprites[randomNumber];
        speed = 1.5f;
        maxAngle = 30f;
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f,0f,maxAngle*Mathf.Sin(speed * Time.time) + 20f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Present")){
            Destroy(other.gameObject);
        }
    }
}
