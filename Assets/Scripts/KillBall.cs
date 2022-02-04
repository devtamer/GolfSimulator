using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    [SerializeField] private Transform Ball;
    public Rigidbody ball;
    [SerializeField] private Transform SpawnPoint;

    void OnTriggerEnter(Collider other)
    {
        ball.velocity = new Vector3(0f, 0f, 0f);
        Ball.transform.position = SpawnPoint.transform.position;

    }


}