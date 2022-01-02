using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildingUIClick : MonoBehaviour
{
    public Button Bld, Bld1, Bld2, Bld3;
    public GameObject BuildingUI;
    void Start()
    {
        Button btn = Bld.GetComponent<Button>();
        btn.onClick.AddListener(OnBldClick);
        Button btn1 = Bld1.GetComponent<Button>();
        btn1.onClick.AddListener(OnBld1Click);
        Button btn2 = Bld2.GetComponent<Button>();
        btn2.onClick.AddListener(OnBld2Click);
        Button btn3 = Bld3.GetComponent<Button>();
        btn3.onClick.AddListener(OnBld3Click);
    }

    private void OnBldClick()
    {
        BuildingUI.transform.position = new Vector3(Convert.ToSingle(1000), -711);
    }
    private void OnBld1Click()
    {
        BuildingUI.transform.position = new Vector3(Convert.ToSingle(1000), -711);
    }
    private void OnBld2Click()
    {
        BuildingUI.transform.position = new Vector3(Convert.ToSingle(1000), -711);
    }
    private void OnBld3Click()
    {
        BuildingUI.transform.position = new Vector3(Convert.ToSingle(1000), -711);
    }
}
