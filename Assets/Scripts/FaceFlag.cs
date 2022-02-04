using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceFlag : MonoBehaviour
{
    public Rigidbody ball;
    public Transform flag;


    // Update is called once per frame

    private void Awake()
    {
    /*    Vector3 rott = new Vector3(flag.eulerAngles.x, flag.eulerAngles.y, flag.eulerAngles.z);
        ball.transform.rotation = Quaternion.Euler(rott);*/
        Vector3 dir = flag.position - ball.transform.position;
        Quaternion rot = Quaternion.LookRotation(dir);
        ball.transform.rotation = rot;
    }
    void FixedUpdate()
    {
        if (ball.velocity.x == 0 && ball.velocity.y == 0 && ball.velocity.z == 0 && PlayerPrefs.GetInt("turning") == 0)
        {
            Vector3 dir = flag.position - ball.transform.position;
            Quaternion rot = Quaternion.LookRotation(dir);
            ball.transform.rotation = rot;

            // ball.transform.LookAt(flag);
            PlayerPrefs.SetInt("turning", 1);

        }
    }
}
