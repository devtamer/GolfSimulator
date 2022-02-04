using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour

{
    [SerializeField] public GameObject GameMenu;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)  {

        Debug.Log(collisionInfo.gameObject.name);
        
        if (collisionInfo.gameObject.name == "flag_med")
            {
                // FindObjectOfType<AudioManager>().PlaySound("Ball_Score");
                Debug.Log("Flag Hit!");
                GameMenu.SetActive(true);
            }

    }
}