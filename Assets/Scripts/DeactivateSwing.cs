using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeactivateSwing : MonoBehaviour
{
    public Rigidbody ball;
    public Image button;
    public Image circle1;
    public Image circle2;
    public TMP_Text text;
    private void Update()
    {
        if (ball.velocity.x >= .1 || ball.velocity.y >= .1 || ball.velocity.z >= .1)
        {
            button.enabled = false;
            circle1.enabled = false;
            circle2.enabled = false;
            text.enabled = false;
        }
        if (ball.velocity.x == 0 && ball.velocity.y == 0 && ball.velocity.z == 0)
        {
            button.enabled = true;
            circle1.enabled = true;
            circle2.enabled = true;
            text.enabled = true;
        }
    }

}
