// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // GameObject player;
    // public Transform target;
    // public float Xmin;
    // public float Xmax;

    // void Start()
    // {
    //     player = GameObject.Find("Player");
    // }

    // void Update()
    // {
    //     Vector3 PlayerPos = player.transform.position;
    //     transform.position = new Vector3(PlayerPos.x, transform.position.y, transform.position.z);
    // }
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;

    private void FixedUpdate() {
        Follow();
    }
    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}