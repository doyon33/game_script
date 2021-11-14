using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed = 10f;
    public float jumpPower = 5f;
    bool isJumping = false;
    Rigidbody2D rigid;
    Rigidbody rid;
    SpriteRenderer rend;
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rid = GetComponent<Rigidbody>();
        rend = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetButtonDown ("Jump"))
        // {
        //     isJumping = true;
        PlayerMove();
        PlayerJump();
        // }
    }
    // private void FixedUpdate() {
    // }
    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
            rend.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
            rend.flipX = true;
        }
    }
    void PlayerJump ()
    {
        if (!isJumping || Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            rid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
}
//     private void OnCollisionEnter(Collision collision)
//     {
//         if (collision.gameObject.CompareTag("ground"))
//         {
//             isJumping = false;
//         }
//     }
// }
