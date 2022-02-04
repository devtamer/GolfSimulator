using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitBall : MonoBehaviour
{
    private Rigidbody ball;
    private Vector3 launchAng;
    [SerializeField] float X, Y, Z;
    
  
    public int clubIndx = 0;
    Vector3[] clubs;
    Vector3 Driver = new Vector3(0f, 12f , 35f);
    Vector3 ThreeW = new Vector3(0f, 14f , 30f);
    Vector3 FiveI = new Vector3(0f, 15f , 24f);
    Vector3 SevenI = new Vector3(0f, 18f , 20f);
    Vector3 Wedge = new Vector3(0f, 25f , 7f);
    Vector3 Putter = new Vector3(0f, 0f , 5f);
    
   
    void Awake()
    {
        ball = GetComponent<Rigidbody>();
        
        clubs = new [] { Putter, Wedge, SevenI, FiveI, ThreeW, Driver};
        launchAng = clubs[clubIndx];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ball.AddForce(launchAng, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.C)){
            clubIndx += 1;
            if(clubIndx == 6){
                clubIndx = 0;
            }
            PlayerPrefs.SetInt("clubSel", clubIndx);
            launchAng = clubs[clubIndx];
        }
    }
}
