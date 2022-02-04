using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBall : MonoBehaviour
{
    public Renderer ball;
    public void Update(){
        if(PlayerPrefs.GetInt("color") == 0)
            ball.material.color = Color.white;
        if(PlayerPrefs.GetInt("color") == 1)
            ball.material.color = Color.red;
        if(PlayerPrefs.GetInt("color") == 2)
            ball.material.color = Color.blue;
        if(PlayerPrefs.GetInt("color") == 3)
            ball.material.color = Color.cyan;
        if(PlayerPrefs.GetInt("color") == 4)
            ball.material.color = Color.yellow;
        if(PlayerPrefs.GetInt("color") == 5)
            ball.material.color = Color.black;
        if(PlayerPrefs.GetInt("color") == 6)
            ball.material.color = Color.grey;
        if(PlayerPrefs.GetInt("color") == 7)
            ball.material.color = Color.magenta;
    }
}
