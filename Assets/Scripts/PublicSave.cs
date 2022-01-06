using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PublicSave
{

    public string saveStringReal;
    public PublicSave()
    {
        System.Random preRawM = new System.Random();
        System.Random preEnergyP = new System.Random();
        System.Random prePopG = new System.Random();

        int RawM_Done = preRawM.Next(0, 1000);
        int EnergyP_Done = preEnergyP.Next(0, 5000);
        double PopG_Done = Math.Round((prePopG.NextDouble() * 1) + 1, 2);

        Text RawMtxt, EnergyPtxt, PopGtxt;

        RawMtxt = GameObject.Find("RawM").GetComponent<Text>();
        RawMtxt.text = Convert.ToString(RawM_Done);
        string saveRawM = "" + Convert.ToString(RawM_Done);

        EnergyPtxt = GameObject.Find("EnergyP").GetComponent<Text>();
        EnergyPtxt.text = Convert.ToString(EnergyP_Done);
        string saveEnergyP = "" + Convert.ToString(EnergyP_Done);

        PopGtxt = GameObject.Find("PopG").GetComponent<Text>();
        PopGtxt.text = Convert.ToString(PopG_Done);
        string savePopG = "" + Convert.ToString(PopG_Done);

        string saveSeparator = "//";
        string[] contents = new string[]
        {
                ""+saveRawM,
                ""+saveEnergyP,
                ""+savePopG
        };
        string saveString = string.Join(saveSeparator, contents);

        saveStringReal = saveString;
    }
}
