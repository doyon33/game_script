using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
    Rigidbody2D rigid;
    SpriteRenderer rend;
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponentInChildren<SpriteRenderer>();
    }
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
            rend.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
            rend.flipX = true;
        }
    }
}