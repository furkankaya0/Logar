using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTheBullet : MonoBehaviour
{
    private float fireRate=0.5F;
    private float nextFire;
    public Transform shotSpawn;
    public GameObject bullet;

    public AudioSource LaserSound;
    
    void Start()
    {

    }

    void Update()
    {
        if(use.usen == true && Time.time > nextFire)
         {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, shotSpawn.position,shotSpawn.rotation); // Showing Example.
            use.usen = false;
            LaserSound.Play();
         }
    }
}
