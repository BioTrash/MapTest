using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Vector3 myPos;
    public GameObject posOffset;
    public GameObject target;
    public float speed;
    private void Start()
    {
        //GameObject Planet = GameObject.Find("posOffset");
        
        PlanetOrbit planetscript = posOffset.GetComponent<PlanetOrbit>();
        speed = planetscript.speed;

        

        if (posOffset.transform.position.x > 0)
        {
            myPos = new Vector3(posOffset.transform.position.x, posOffset.transform.position.y, posOffset.transform.position.z) - new Vector3(posOffset.transform.localScale.x * 5, 0, -(posOffset.transform.localScale.x -3));
        }
        else
        {
            myPos = new Vector3(posOffset.transform.position.x, posOffset.transform.position.y, posOffset.transform.position.z) - new Vector3(-posOffset.transform.localScale.x * 5, 0, (posOffset.transform.localScale.x - 3));
        }
        gameObject.transform.localPosition = myPos;
    }
    public void Update()
    {
        
        transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
    }

}
