using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraChange : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public TrailRenderer trail1;
    public TrailRenderer trail2;
    public TrailRenderer trail3;
    public Button btn;
    Ray ray;
    RaycastHit hit;
    int i = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        btn.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            i = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            i = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            i = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            i = 3;   
        }

        if (i == 0)
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = false;
            btn.gameObject.SetActive(false);
        }
        else if (i == 1)
        {

            cam1.enabled = false;
            cam2.enabled = true;
            cam3.enabled = false;
            cam4.enabled = false;
            btn.gameObject.SetActive(true);
        }
        else if (i == 2)
        {

            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true;
            cam4.enabled = false;
            btn.gameObject.SetActive(true);
        }
        else if (i == 3)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = false;
            cam4.enabled = true;
            btn.gameObject.SetActive(true);
        }

        if (cam1.enabled != true)
        {
            trail1.enabled = false;
            trail2.enabled = false;
            trail3.enabled = false;
        }
        else
        {
            trail1.enabled = true;
            trail2.enabled = true;
            trail3.enabled = true;
        }
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.name == "1")
                {
                    i = 1;
                }
                else if (hit.collider.name == "2")
                {
                    i = 2;
                }
                else if (hit.collider.name == "3")
                {
                    i = 3;
                }
                else
                {
                    i = 0;
                }
            }

        }
        
    }
}
