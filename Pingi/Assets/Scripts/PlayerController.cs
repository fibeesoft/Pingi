using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject presentPrefab;
    bool jump;
    bool isGrounded;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = false;
        isGrounded= true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            ShootPresent();
        }

        jump = Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire2");
    }

    private void FixedUpdate() {
        
        if(jump && isGrounded){
            rb.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
            isGrounded = false;
        }
        
    }

    public void ShootPresent(){
        GameObject present = Instantiate(presentPrefab, transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }
}
