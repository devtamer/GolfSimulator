using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour
{

    private int index;
    public TMP_InputField nickName;
    private GameObject placeHolder;
    public Button Normal;
    public Button Hard;

    private void Start()
    {

    }

    public void ConfirmButton()
    {
        SceneManager.LoadScene("Hole1");
        GetUserNickname();
        // SetDifficultyHard();
        // SetDifficultyNormal();
    }
    public void GetUserNickname()
    {
        PlayerPrefs.SetString("Nickname", nickName.text);
    }
    public void SetDifficultyNormal()
    {
        PlayerPrefs.SetString("Difficulty", "Normal");
    }
    public void SetDifficultyHard()
    {
        PlayerPrefs.SetString("Difficulty", "Hard");
    }
}
