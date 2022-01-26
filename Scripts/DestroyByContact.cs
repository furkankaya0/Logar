using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public int scoreVal;
    private GameController gameController;
    private HealthBar HealthBar;
    public GameObject explosionEffect;
    bool hasExploded = false;
    private AudioSource Explosion;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").
        GetComponent<GameController>();
        HealthBar = GameObject.FindGameObjectWithTag("GameController").
        GetComponent<HealthBar>();
    }
    private void OnTriggerEnter(Collider other)
    {       
        if(other.CompareTag("Astroid"))
        {
            
            if (!hasExploded)
            {
                Instantiate(explosionEffect,transform.position,transform.rotation);
                //Explosion.Play();
                hasExploded = true;
            }
                gameController.addScore(1);
                Destroy(other.gameObject);
                Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            
            if (!hasExploded)
            {
;
                Instantiate(explosionEffect,transform.position,transform.rotation);
                hasExploded = true;  

            }
                Destroy(other.gameObject);
                Destroy(gameObject);
                HealthBar.HealthBars(3);
                gameController.Health(3);
        }
    }
}
