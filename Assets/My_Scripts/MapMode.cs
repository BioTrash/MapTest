using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapMode : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    
   
    public void LoadMap()
    {
        if(cam1.enabled == true)
        {
            SceneManager.LoadScene(1);
        }
       

    }

    
}
