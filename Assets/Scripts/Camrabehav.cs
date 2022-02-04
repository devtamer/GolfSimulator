using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camrabehav : MonoBehaviour
{
    public Rigidbody ball;
    public CinemachineFreeLook cam;
    public Transform flag;
    private bool changed;
  
    private void FixedUpdate()
    {
        if (ball.velocity.x >= .1 || ball.velocity.y >= .1 || ball.velocity.z >= .1 )
        {
            
            cam.m_BindingMode = CinemachineTransposer.BindingMode.WorldSpace;
            PlayerPrefs.SetInt("noSwing", 1);

        }
        if (ball.velocity.x >= .5 || ball.velocity.y >= .5 || ball.velocity.z >= .5)
        {
            changed = false;
        }
        if (ball.velocity.x <= .1 && ball.velocity.y <= 0.1 && ball.velocity.z <= 0.1)
        {
            cam.m_BindingMode = CinemachineTransposer.BindingMode.LockToTargetWithWorldUp;
            PlayerPrefs.SetInt("noSwing", 0);
            
  
            if (changed == false)
            {
                Vector3 dir = flag.position - ball.transform.position;
                Quaternion rot = Quaternion.LookRotation(dir);
                ball.transform.rotation = rot;
                changed = true;
            }
            
        }
        
    }
    
       
        
    
}