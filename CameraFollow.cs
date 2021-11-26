using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;
    public Transform target;
    public float Xmin;
    public float Xmax;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 PlayerPos = player.transform.position;
        transform.position = new Vector3(PlayerPos.x, transform.position.y, transform.position.z);
    }
}