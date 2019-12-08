using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject snowballPrefab;
    [SerializeField] Sprite[] sprites;

    SpriteRenderer enemySprite;
    void Start()
    {
        enemySprite = GetComponentInChildren<SpriteRenderer>();
        int randomNumber = Random.Range(0, sprites.Length);
        enemySprite.sprite = sprites[randomNumber];
        InvokeRepeating("ShootASnowBall", Random.Range(0.5f, 2f), Random.Range(1.6f, 2.4f));
    }

    void ShootASnowBall(){
        GameObject snowball = Instantiate(snowballPrefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
