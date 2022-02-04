using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ballstuck : MonoBehaviour
{
    public Rigidbody ball;
    public CinemachineFreeLook cam;
    public Transform flag;
    public void getballunStuck(){
        ball.velocity = new Vector3(0f,0f,0f);
        Vector3 dir = flag.position - ball.transform.position;
        Quaternion rot = Quaternion.LookRotation(dir);
        ball.transform.rotation = rot;

    }
}