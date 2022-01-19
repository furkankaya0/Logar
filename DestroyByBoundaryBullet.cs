using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundaryBullet : MonoBehaviour
{ 
    private GameController gameController;
    private void Start()
    {
        GetComponent<GameController>();

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }


    }
}
