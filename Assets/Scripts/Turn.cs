using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;
    private float rot;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 camrapos = ball.position + offset;

        transform.position = camrapos;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.Rotate(0f, 90f * Time.deltaTime, 0f);

            //Quaternion deltaRotation = Quaternion.Euler(AdjAng * Time.deltaTime);
            //ball.MoveRotation(ball.rotation * deltaRotation);

            //rotationY += Input.GetAxis("Horizontal") * Time.deltaTime;
            transform.Rotate(0.0f, 45.0f, 0.0f, Space.Self);
            rot -= 1;
            PlayerPrefs.SetFloat("rot", rot);

            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //transform.Rotate(0f, 90f * Time.deltaTime, 0f);

            //Quaternion deltaRotation = Quaternion.Euler(AdjAng * Time.deltaTime);
            //ball.MoveRotation(ball.rotation * deltaRotation);

            //rotationY += Input.GetAxis("Horizontal") * Time.deltaTime;
            transform.Rotate(0.0f, -45.0f, 0.0f, Space.Self);
            rot += 1;
            PlayerPrefs.SetFloat("rot", rot);

            Debug.Log("D");
        }
    }
}
