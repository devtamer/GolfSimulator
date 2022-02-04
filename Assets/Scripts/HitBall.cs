using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitBall : MonoBehaviour
{
    private Rigidbody ball;
    private Vector3 launchAng;
    public Transform camara;
    public Transform flag;



    public int clubIndx = 0;
    private int currStroke = 0;
    private int strokesRemaining = 10;

    [SerializeField] public GameObject creditScene;

    Vector3[] clubs;
    Vector3 Driver = new Vector3(0f, 12f, 35f);
    Vector3 ThreeW = new Vector3(0f, 14f, 30f);
    Vector3 FiveI = new Vector3(0f, 15f, 24f);
    Vector3 SevenI = new Vector3(0f, 20f, 20f);
    Vector3 Wedge = new Vector3(0f, 25f, 7f);
    Vector3 Putter = new Vector3(0f, 0f, 30f);
    Vector3 AdjAng = new Vector3(0f, 0f, 0f);
    public Vector3 offset;
    //float rotationY = 0;

    void Start()
    {
    }
    void Awake()
    {
        ball = GetComponent<Rigidbody>();

        clubs = new[] { Putter, Wedge, SevenI, FiveI, ThreeW, Driver };
        launchAng = clubs[clubIndx];
        PlayerPrefs.SetInt("turning", 0);
        PlayerPrefs.SetInt("stroke", currStroke);
        PlayerPrefs.SetInt("strokesRemaining", strokesRemaining);
        if (PlayerPrefs.GetString("Difficulty") == "Hard")
        {
            strokesRemaining = 7;

        }
        else
        {
            strokesRemaining = 15;
        }


    }

    // Update is called once per frame
    void Update()
    {


        float currentPow = PlayerPrefs.GetFloat("power");

        if (currentPow != 0 & CheckStill(ball) == true)
        {
            ball.AddRelativeForce(launchAng * (currentPow + 0.15f), ForceMode.Impulse);
            PlayerPrefs.SetInt("turning", 0);
            PlayerPrefs.SetFloat("power", 0.0f);
            currStroke += 1;
            strokesRemaining -= 1;
            PlayerPrefs.SetInt("strokesRemaining", strokesRemaining);
            PlayerPrefs.SetInt("stroke", currStroke);
        }

        if (Input.GetKeyDown(KeyCode.A) & CheckStill(ball) == true)
        {
            PlayerPrefs.SetInt("turning", 1);
            ball.transform.Rotate(0.0f, -3.0f, 0.0f, Space.Self);
            Vector3 camrapos = ball.position + offset;
            camara.position = camrapos;
            Debug.Log("A");
        }

        if (Input.GetKeyDown(KeyCode.D) & CheckStill(ball) == true)
        {
            PlayerPrefs.SetInt("turning", 1);
            ball.transform.Rotate(0.0f, 3.0f, 0.0f, Space.Self);
            Vector3 camrapos = ball.position + offset;
            camara.position = camrapos;
            Debug.Log("D");
        }

        if (Input.GetKeyDown(KeyCode.C) & CheckStill(ball) == true)
        {
            clubIndx += 1;
            if (clubIndx == 6)
            {
                clubIndx = 0;
            }
            PlayerPrefs.SetInt("clubSel", clubIndx);
            launchAng = clubs[clubIndx];
        }
        if (Input.GetKeyDown(KeyCode.E) & CheckStill(ball) == true)
        {
            PlayerPrefs.SetInt("turning", 1);
            ball.transform.Rotate(0.0f, 35.0f, 0.0f, Space.Self);
            Vector3 camrapos = ball.position + offset;
            camara.position = camrapos;

        }
        if (Input.GetKeyDown(KeyCode.Q) & CheckStill(ball) == true)
        {
            PlayerPrefs.SetInt("turning", 1);
            ball.transform.Rotate(0.0f, -35.0f, 0.0f, Space.Self);
            Vector3 camrapos = ball.position + offset;
            camara.position = camrapos;

        }
        if (strokesRemaining == 0)
        {
            creditScene.SetActive(true);

        }



    }
    public bool CheckStill(Rigidbody item)
    {
        if (item.velocity.x == 0 && item.velocity.y == 0 && item.velocity.z == 0)
            return true;
        else
            return false;

    }
}
