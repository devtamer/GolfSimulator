using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powermeter : MonoBehaviour
{
    public Image img;
    // Start is called before the first frame update
    public void GetSwing()
    {
        if(PlayerPrefs.GetInt("noSwing") == 0)
        {
            float power = img.fillAmount;
            PlayerPrefs.SetFloat("power", power);
        }
        
    }
}
