using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    private  GameController gameController;
    private HealthBar HealthBar;
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").
        GetComponent<GameController>();
        HealthBar = GameObject.FindGameObjectWithTag("GameController").
        GetComponent<HealthBar>();




    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject);
            gameController.Health(1);
            HealthBar.HealthBars(1);
        }


    }

}
