using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    Animator animator;
    SpriteRenderer rend;
    public float speed = 1.0f;
    public GameObject target;


    void Start()
    {
        rend = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        Move();

    }
    private void Move()
    {
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();
        dir.y = 0;
        transform.position += dir * speed * Time.deltaTime;


        if (dir.x > 0)
        {
            rend.flipX = true;
            animator.SetBool("fight", false);
        }
        else if (dir.x < 0)
        {
            rend.flipX = false;
            animator.SetBool("fight", false);
        }
    }
    
}
