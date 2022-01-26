using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedOfAstroids : MonoBehaviour
{
    private float speed= -5;
    private void Start()
    {
        int score = GameController.score;

        if (score < 50)         //LEVEL 1
        {
            speed = -5.5f;

        }
        else if (score >= 50 && score < 110)           //LEVEL 2
        {
            speed = -6;
        }
        else if (score >= 110 && score < 220)          //LEVEL 3
        {
            speed = -7;

        }
        else if (score >= 230 && score < 380)          //LEVEL 4
        {
            speed = -8;
        }
        else if (score >= 380 && score < 570)          //LEVEL 5
        {
            speed = -9f;
        }
        else if (score >= 570 && score < 770)          //LEVEL 6
        {
            speed = -10;
        }
        else if (score >= 770 && score < 980)          //LEVEL 7
        {
            speed = -11;
        }
        else if (score >= 980 && score < 1200)          //LEVEL 4
        {
            speed = -12;
        }
        else if (score >= 1200 && score < 1420)          //LEVEL 8
        {
            speed = -13.5f;
        }
        else if (score >= 1420 && score < 1650)          //LEVEL 9
        {
            speed = -15;
        }
        else if (score >= 1650)                          //LEVEL 10
        {
            speed = -15;
        }
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    void Update()
    {

    }

}
