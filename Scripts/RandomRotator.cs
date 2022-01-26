using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    private float tumble = 1; // tumble = takla atmak

    void Start()
    {
        this.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble; 
    }

}
