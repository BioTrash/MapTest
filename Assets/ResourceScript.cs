using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResourceScript
{
    public string saveStringReal;
    public ResourceScript()
    {
        Text energy_Pot_txt, energy_Pro_txt;

        System.Random energy_Pot = new System.Random();

        int _energy_Pot = energy_Pot.Next(999, 9999);
        int _energy_Pro = 0; //To be modified with buildings, 0 as a place holder for now

        energy_Pot_txt = GameObject.Find("Energy_Pot").GetComponent<Text>();
        energy_Pot_txt.text = Convert.ToString(_energy_Pot);
        string savePotValue = "" + Convert.ToString(_energy_Pot);

        energy_Pro_txt = GameObject.Find("Energy_Pot").GetComponent<Text>();
        energy_Pro_txt.text = Convert.ToString(_energy_Pro);
        string saveProValue = "" + Convert.ToString(_energy_Pro);

        string saveSeparator = "//";
        string[] contents = new string[]
        {
            ""+savePotValue,
            ""+saveProValue
        };
        string saveString = string.Join(saveSeparator, contents);

        saveStringReal = saveString;
    }
}
