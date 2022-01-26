using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float Xmin, Xmax, Zmin, Zmax; //for minimazing we create class and under it we can set our values
}
public class PlayerController : MonoBehaviour
{
    public FloatingJoystick joystick;
    private new Rigidbody rigidbody;
    /*public float Xmin;
    public float Zmin;
    public float Xmax;
    public float Zmax; */  //it covers so much space
    public Boundary boundary;
    private float speed= 12;
    public float tilt;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>() as Rigidbody; //we call the compenent
        speed = 12;
    }


    private void FixedUpdate()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;

        Vector3 movement = new Vector3(-moveVertical, 0f, moveHorizontal);

        rigidbody.velocity = movement * speed;

        rigidbody.position = new Vector3(
            Mathf.Clamp(rigidbody.position.x, boundary.Xmin, boundary.Xmax),
            0.0f,
            Mathf.Clamp(rigidbody.position.z, boundary.Zmin, boundary.Zmax));

        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt); //!!!!! Player turns to -x side */
    }

    private void Update()
    {
        if(GameController.health<=0)
        {
            speed = 0;
        }
    }

}

