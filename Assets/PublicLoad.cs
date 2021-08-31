using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PublicLoad
{
    public Text RawM, EnergyP, PopG;
    public PublicLoad()
    {
        Text RawMtxt, EnergyPtxt, PopGtxt;

        RawMtxt = GameObject.Find("RawM").GetComponent<Text>();
        EnergyPtxt = GameObject.Find("EnergyP").GetComponent<Text>();
        PopGtxt = GameObject.Find("PopG").GetComponent<Text>();

        RawM = RawMtxt;
        EnergyP = EnergyPtxt;
        PopG = PopGtxt;
    }
}
