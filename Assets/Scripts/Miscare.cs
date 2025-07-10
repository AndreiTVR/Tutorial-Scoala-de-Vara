using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Miscare : MonoBehaviour
{
    private Rigidbody2D rb;
    public int viata;
    
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    
    private bool isJumping = false;

    private bool damage = false;
    // Start is called before the first frame update
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Inamic"))
        {
            damage = true;
        }
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }

        if (damage && viata > 0)
        {
            viata--;
            damage = false;
        }else if (viata <= 0)
        {
            SceneManager.LoadScene("SampleScene");
            damage = false;
        }
    }
}
