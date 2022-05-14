using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyCamera : MonoBehaviour
{

    /*
    wasd : basic movement
    shift : Makes camera accelerate
    space : Moves camera on X and Z axis only.  So camera doesn't gain any height*/
    public float speed = 3.5f;
    private float X;
    private float Y;
    float mainSpeed = 100.0f; //regular speed
    float shiftAdd = 250.0f; //multiplied by how long shift is held.  Basically running
    float maxShift = 1000.0f; //Maximum speed when holdin gshift 
    private float totalRun = 1.0f;
    public GameObject cam;






    void Update()
    {
        //Camera borders for the world
        if (Input.GetKey(KeyCode.W) && cam.transform.position.x >= 700 || Input.GetKey(KeyCode.A) && cam.transform.position.x >= 700 || Input.GetKey(KeyCode.S) && cam.transform.position.x >= 700 || Input.GetKey(KeyCode.D) && cam.transform.position.x >= 700)
        {
            cam.transform.position = new Vector3(699, cam.transform.position.y, cam.transform.position.z);
                 
        }
        if (Input.GetKey(KeyCode.W) && cam.transform.position.x <= -700 || Input.GetKey(KeyCode.A) && cam.transform.position.x <= -700 || Input.GetKey(KeyCode.S) && cam.transform.position.x <= -700 || Input.GetKey(KeyCode.D) && cam.transform.position.x <= -700)
        {
            cam.transform.position = new Vector3(-699, cam.transform.position.y, cam.transform.position.z);

        }
        if (Input.GetKey(KeyCode.W) && cam.transform.position.y >= 700 || Input.GetKey(KeyCode.A) && cam.transform.position.y >= 700 || Input.GetKey(KeyCode.S) && cam.transform.position.y >= 700 || Input.GetKey(KeyCode.D) && cam.transform.position.y >= 700)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, 699, cam.transform.position.z);

        }
        if (Input.GetKey(KeyCode.W) && cam.transform.position.y<= -700 || Input.GetKey(KeyCode.A) && cam.transform.position.y <= -700 || Input.GetKey(KeyCode.S) && cam.transform.position.y <= -700 || Input.GetKey(KeyCode.D) && cam.transform.position.y <= -700)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, -699, cam.transform.position.z);

        }
        if (Input.GetKey(KeyCode.W) && cam.transform.position.z >= 700 || Input.GetKey(KeyCode.A) && cam.transform.position.z >= 700 || Input.GetKey(KeyCode.S) && cam.transform.position.z >= 700 || Input.GetKey(KeyCode.D) && cam.transform.position.z >= 700)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, 699);

        }
        if (Input.GetKey(KeyCode.W) && cam.transform.position.z <= -700 || Input.GetKey(KeyCode.A) && cam.transform.position.z <= -700 || Input.GetKey(KeyCode.S) && cam.transform.position.z <= -700 || Input.GetKey(KeyCode.D) && cam.transform.position.z <= -700)
        {
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, -99);

        }
        
        
        //Mouse camera look around 

        if (Input.GetMouseButton(2))
        {
            transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * speed, Input.GetAxis("Mouse X") * speed, 0));
            X = transform.rotation.eulerAngles.x;
            Y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(X, Y, 0);
        }

            

            //Keyboard commands

            Vector3 p = GetBaseInput();
        if (p.sqrMagnitude > 0)
        { // only move while a direction key is pressed
            if (Input.GetKey(KeyCode.LeftShift))
            {
                totalRun += Time.deltaTime;
                p = p * totalRun * shiftAdd;
                p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
                p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
                p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
            }
            else
            {
                totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
                p = p * mainSpeed;
            }

            p = p * Time.deltaTime;
            Vector3 newPosition = transform.position;



            if (Input.GetKey(KeyCode.Space))
            { //If player wants to move on X and Z axis only
                transform.Translate(p);
                newPosition.x = transform.position.x;
                newPosition.z = transform.position.z;
                transform.position = newPosition;
            }
            else
            {
                transform.Translate(p);
            }
        }

        
    }

    private Vector3 GetBaseInput()
    { //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }
        return p_Velocity;
    }
    

}
    