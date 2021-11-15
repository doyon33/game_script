using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rigid;
    bool isJumping;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    public float jumpPower = 5f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isJumping = false;
        }
    }
    private void FixedUpdate() {
        Jump();
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        // }
    }
    void Jump()
    {
        if (Input.GetButton("Jump"))
        {
            if (isJumping == false)
            {
                rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                isJumping = true;
            }
            else return;
        }
    }
}
