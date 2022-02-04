using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public TextMeshProUGUI nickNameDisplay;
    [SerializeField] public TextMeshProUGUI strokesRemaining;


    void Start()
    {


    }

    void Update()
    {
        nickNameDisplay.text = "Welcome " + PlayerPrefs.GetString("Nickname");
        strokesRemaining.text = "Strokes Remaining: " + PlayerPrefs.GetInt("strokesRemaining").ToString();


    }

}
