using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public GameObject a;
    public Speedclass speedvar;

    void Start()
    {
        speedvar = a.GetComponent<Speedclass>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, speed * speedvar.speed * Time.deltaTime);
    }
}
