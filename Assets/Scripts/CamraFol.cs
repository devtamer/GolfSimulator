using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraFol : MonoBehaviour
{
    
    public Transform ball;
    public Vector3 offset;
    // Start is called before the first frame update
    void Update(){
        Vector3 camrapos = ball.position + offset;
        transform.position = camrapos;
    }
}
