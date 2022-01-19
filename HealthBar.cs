using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image HealthBar1;
    public Image HealthBar2;
    public Image HealthBar3;

    private int health= 3;
    // Start is called before the first frame update

    private void Start()
    {
        HealthBar1.gameObject.SetActive(true);
        HealthBar2.gameObject.SetActive(true);
        HealthBar3.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

        if(health<3)
        {
            HealthBar3.gameObject.SetActive(false);
            //Debug.Log("HB3");
        }
        if (health < 2)
        {
            HealthBar3.gameObject.SetActive(false);
            HealthBar2.gameObject.SetActive(false);
        }
        if (health <1)
        {
            HealthBar1.gameObject.SetActive(false);
            HealthBar2.gameObject.SetActive(false);
            HealthBar3.gameObject.SetActive(false);
            
        }



    }

    public void HealthBars(int newScoreVal)
    {
        //Debug.Log(health);
        health -= newScoreVal;
    }
}
