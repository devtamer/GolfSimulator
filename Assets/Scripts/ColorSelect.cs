using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Image colorImg;
    private int col = 0;
    public void Start(){
        PlayerPrefs.SetInt("color", col);
    }
    public void giveColor(){
        
        col+=1;
        if(col == 8)
            col = 0;
        PlayerPrefs.SetInt("color", col);
        if(col == 0)
            colorImg.color = Color.white;
        if(col == 1)
            colorImg.color = Color.red;
        if(col == 2)
            colorImg.color = Color.blue;
        if(col == 3)
            colorImg.color = Color.cyan;
        if(col == 4)
            colorImg.color = Color.yellow;
        if(col == 5)
            colorImg.color = Color.black;
        if(col == 6)
            colorImg.color = Color.grey;
        if(col == 7)
            colorImg.color = Color.magenta;
    }
}
