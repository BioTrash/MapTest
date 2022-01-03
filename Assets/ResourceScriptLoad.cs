using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceScriptLoad
{
    public Text Energy_Pot, Energy_Pro;
    public ResourceScriptLoad()
    {
        Text energy_Pot_txt, energy_Pro_txt;

        energy_Pot_txt = GameObject.Find("Energy_Pot").GetComponent<Text>();
        energy_Pro_txt = GameObject.Find("Energy_Pro").GetComponent<Text>();

        Energy_Pot = energy_Pot_txt;
        Energy_Pro = energy_Pro_txt;
    }

}
