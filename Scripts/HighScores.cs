using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public Text highScore;

    void Start()
    {
       PlayerPrefs.GetInt("HighScore");
       highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
