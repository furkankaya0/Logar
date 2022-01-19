using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject Astroid1;
    public GameObject Astroid2;
    public GameObject Astroid3;
    
    private int Astroid1Count;
    private int Astroid2Count;
    private int Astroid3Count;

    public Vector3 SpawnValues;
    private float spawnWait= 1;
    //private float startWait= 2;
    private float waveWait = 5;
    // OBJECTS
    public GameObject ShootButton;
    public GameObject Joystick;


    public static int health = 3;
    public static int score = 0;
    public Text ScoreText;
    public Text highScore;
    //Game over
    private bool gameover;
    public Text GameOverScore;
    public GameObject GameoverPanel;
    public Text levels;
    private int level;
    
    //Audio
    public AudioSource PlayScreenMusic;
    public AudioSource GameOverEffect;
    public AudioSource Explosion;


    void Start()
    {

        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        Time.timeScale = 1;
        level = 1;
        score = 0;
        health=3;
        ScoreText.text = score.ToString();
        StartCoroutine(spawnWave());
        PlayScreenMusic.Play();
        gameover = false;

    }
    void Update()
    {
        if (score < 50)         //LEVEL 1
        {
            level = 1;
            levels.text =level+"";
            LevelChange();
            Astroid1Count = 4;
            Astroid2Count = 1;
            Astroid3Count = 0;

        }
        else if (score >= 50 && score< 110)           //LEVEL 2
        {
            level = 2;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 4;
            Astroid2Count = 2;
            Astroid3Count = 1;

        }
        else if (score >= 110 && score < 220)          //LEVEL 3
        {
            level = 3;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 6;
            Astroid2Count = 3;
            Astroid3Count = 2;
            spawnWait = 0.9f;
        }
        else if (score >= 230 && score < 380)          //LEVEL 4
        {
            level = 4;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 8;
            Astroid2Count = 4;
            Astroid3Count = 3;
            spawnWait = 0.9f;

        }
        else if (score >= 380 && score < 570)          //LEVEL 5
        {
            level = 5;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 10;
            Astroid2Count = 5;
            Astroid3Count = 4;
            spawnWait = 0.85f;
        }
        else if (score >= 570 && score < 770)          //LEVEL 6
        {
            level = 6;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 10;
            Astroid2Count = 6;
            Astroid3Count = 4;
            spawnWait = 0.8f;
        }
        else if (score >= 770 && score < 980)          //LEVEL 7
        {
            level = 7;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 10;
            Astroid2Count = 6;
            Astroid3Count = 5;
            spawnWait = 0.77f;
        }
        else if (score >= 980 && score < 1200)          //LEVEL 8
        {
            level = 8;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 11;
            Astroid2Count = 6;
            Astroid3Count = 5;
            spawnWait = 0.75f;
        }
        else if (score >= 1200 && score < 1420)          //LEVEL 9
        {
            level = 9;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 11;
            Astroid2Count = 4;
            Astroid3Count = 7;
            spawnWait = 0.75f;
        }
        else if (score >= 1420 && score < 1650)          //LEVEL 10
        {
            level = 10;
            levels.text = level + "";
            LevelChange();
            Astroid1Count =10;
            Astroid2Count = 5;
            Astroid3Count = 8;
            spawnWait = 0.7f;
        }
        else if (score >= 1650)                          //LEVEL 11
        {
            level = 11;
            levels.text = level + "";
            LevelChange();
            Astroid1Count = 10;
            Astroid2Count = 10;
            Astroid3Count = 10;
            spawnWait = 0.7f;
        }
        GameOverScore.text = score+ "";
        Gameover();

        if (score   >   PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }else
        {
            PlayerPrefs.GetInt("HighScore");
        }
    }
    IEnumerator spawnWave()
    {
        while (true)
        {

            for (int i = 0; i < Astroid1Count; i++)         // Astroid 1 Createor
            {

            Vector3 spawnPosition = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x),
                SpawnValues.y, SpawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(Astroid1, spawnPosition, spawnRotation); // Vector3-�nsantiate location and spawn
                yield return new WaitForSeconds(spawnWait);

            }
            for (int i = 0; i < Astroid3Count; i++)         // Astroid 3 Createor
            {

                Vector3 spawnPosition2 = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x),
                    SpawnValues.y, SpawnValues.z);
                Quaternion spawnRotation2 = Quaternion.identity;
                Instantiate(Astroid3, spawnPosition2, spawnRotation2); // Vector3-�nsantiate location and spawn
                yield return new WaitForSeconds(spawnWait);
            }
            for (int i = 0; i < Astroid2Count; i++)          // Astroid 2 Createor
            {
       
                Vector3 spawnPosition1 = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x),
                    SpawnValues.y, SpawnValues.z);
                Quaternion spawnRotation1 = Quaternion.identity;
                Instantiate(Astroid2, spawnPosition1, spawnRotation1); // Vector3-�nsantiate location and spawn
                yield return new WaitForSeconds(spawnWait);
            }

            for (int i = 0; i < Astroid3Count; i++)         // Astroid 3 Createor
            {

                Vector3 spawnPosition2 = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x),
                    SpawnValues.y, SpawnValues.z);
                Quaternion spawnRotation2 = Quaternion.identity;
                Instantiate(Astroid3, spawnPosition2, spawnRotation2); // Vector3-�nsantiate location and spawn
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

        }
    }

    public void addScore(int newScoreVal)
    {
        //Debug.Log(" +1 score ");
        score += 10*newScoreVal;

        updateScore();

    }
    public void updateScore()
    {
        ScoreText.text =score.ToString();
    }
    IEnumerator LevelChange()
    {
        yield return new WaitForSeconds(5);
    }

    public void Health(int newScoreVal)
    {
        //Debug.Log(health);
        health -= newScoreVal;
    }
    
    public void Gameover()
    {
        if( health<=0)
        {
            Time.timeScale = 0;
            GameoverPanel.gameObject.SetActive(true);
            ShootButton.gameObject.SetActive(false);
            Joystick.gameObject.SetActive(false);
            if (gameover == false)
            {
                PlayScreenMusic.Pause();
                GameOverEffect.Play();
                gameover = true;
            }
        }
        else
        {
            Joystick.gameObject.SetActive(true);
            ShootButton.gameObject.SetActive(true);
            GameoverPanel.gameObject.SetActive(false);
            Time.timeScale = 1;
        }


        if (health <= 0 && gameover==false)
        {
            PlayScreenMusic.Pause();
            GameOverEffect.Play();
            //Debug.Log("TimeDone");
            gameover = true;
        }

    }

    public void timeScale()
    {
        Time.timeScale = 1;
    }
}


//