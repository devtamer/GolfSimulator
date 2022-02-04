using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Club : MonoBehaviour
{
    public TMP_Text clubSel;
    private int club;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        club = PlayerPrefs.GetInt("clubSel");
        if(club == 5){
            clubSel.text = "Driver";
        }
        if(club == 4){
            clubSel.text = "Three Wood";
        }
        if(club == 3){
            clubSel.text = "Five Iron";
        }
        if(club == 2){
            clubSel.text = "Seven Iron";
        }
        if(club == 1){
            clubSel.text = "Wedge";
        }
        if(club == 0){
            clubSel.text = "Putter";
        }
    }
}
