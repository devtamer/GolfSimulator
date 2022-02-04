using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Club : MonoBehaviour
{
    public TMP_Text clubSel;
    public TMP_Text Strokecount;
    public TMP_Text strokeRemaining;


    private int club;

    // Update is called once per frame
    private void Awake()
    {
        PlayerPrefs.SetInt("clubSel", 0);
        Strokecount.text = (PlayerPrefs.GetInt("stroke")).ToString();
        strokeRemaining.text = (PlayerPrefs.GetInt("strokeRemaining")).ToString();

    }

    void FixedUpdate()
    {
        club = PlayerPrefs.GetInt("clubSel");
        Strokecount.text = (PlayerPrefs.GetInt("stroke")).ToString();
        strokeRemaining.text = (PlayerPrefs.GetInt("strokeRemaining")).ToString();

        if (club == 5)
        {
            clubSel.text = "Driver";
        }
        if (club == 4)
        {
            clubSel.text = "Three Wood";
        }
        if (club == 3)
        {
            clubSel.text = "Five Iron";
        }
        if (club == 2)
        {
            clubSel.text = "Seven Iron";
        }
        if (club == 1)
        {
            clubSel.text = "Wedge";
        }
        if (club == 0)
        {
            clubSel.text = "Putter";
        }
    }
}
