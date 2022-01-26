using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    private float speed = 20;
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }


    }
}

