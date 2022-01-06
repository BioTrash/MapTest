using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SideUIClick : MonoBehaviour
{
    public Button Energy, Population, Farming, Industry;
    public GameObject MapSideUI, EnergyUI, PopulationUI, FarmingUI, IndustryUI; //ResearchUI to be added
    void Start()
    {
        Button btn = Energy.GetComponent<Button>();
        btn.onClick.AddListener(OnEnergyClick);

        Button btn1 = Population.GetComponent<Button>();
        btn1.onClick.AddListener(OnPopulationClick);

        Button btn2 = Farming.GetComponent<Button>();
        btn2.onClick.AddListener(OnFarmingClick);

        Button btn3 = Industry.GetComponent<Button>();
        btn3.onClick.AddListener(OnIndustryClick);
    }

    private void OnEnergyClick()
    {
        EnergyUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
    }

    private void OnPopulationClick()
    {
        PopulationUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
    }

    private void OnFarmingClick()
    {
        FarmingUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
    }

    private void OnIndustryClick()
    {
        IndustryUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
    }
}
