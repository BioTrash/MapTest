using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Speedclass : MonoBehaviour
{
    public float speed = 0.2f;
    public Button SpeedUp;
    public Button SpeedDown;
    public int S = 0;
    // Start is called before the first frame update
    void Start()
    {
        Button SU = SpeedUp.GetComponent<Button>();
        Button SD = SpeedDown.GetComponent<Button>();
        SU.onClick.AddListener(TaskOnClickSU);
        SD.onClick.AddListener(TaskOnClickSD);
        
    }
    void TaskOnClickSU()
    {
        S = 1;
    }
    
    void TaskOnClickSD()
    {
        S = -1;
    }
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.N) && speed > 0.2f || S == -1 && speed > 0.2f)
        {
            speed += -0.2f;
            S = 0;
        }
        else if (Input.GetKeyDown(KeyCode.M) || S == 1)
        {
            speed += 0.2f;
            S = 0;
            
        }
    }
}
