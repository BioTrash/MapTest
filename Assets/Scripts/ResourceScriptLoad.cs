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
    public Text Arable_Land, Fertility, Used_Land, Provisions_Pro, Farm_E_Need, Farm_E_Use;
    public Text Raw_Mat, Bld_Mat, Con_Goods, Ind_E_Need, Ind_E_Use;
    public Text Tot_Pop, Attitude, Provisions_Need, Provisions_Con, Con_Goods_Need, Con_Goods_Con, Pop_E_Need, Pop_E_Use;
    public ResourceScriptLoad()
    {
        Text energy_Pot_txt, energy_Pro_txt;
        Text arable_Land_txt, fertility_txt, used_Land_txt, provisions_Pro_txt, farm_E_need_txt, farm_E_use_txt;
        Text raw_Mat_txt, bld_Mat_txt, con_Goods_txt, ind_E_need_txt, ind_E_use_txt;
        Text tot_Pop_txt, attitude_txt, provisions_Need_txt, provisions_Con_txt, con_Goods_need_txt, con_Goods_con_txt, pop_E_need_txt, pop_E_use_txt;

        energy_Pot_txt = GameObject.Find("Energy_Pot").GetComponent<Text>();
        energy_Pro_txt = GameObject.Find("Energy_Pro").GetComponent<Text>();

        arable_Land_txt = GameObject.Find("Arable_Land").GetComponent<Text>();
        fertility_txt = GameObject.Find("Fertility").GetComponent<Text>();
        used_Land_txt = GameObject.Find("Cultivated_Land").GetComponent<Text>();
        provisions_Pro_txt = GameObject.Find("Provisions_Pro").GetComponent<Text>();
        farm_E_need_txt = GameObject.Find("Energy_Farm_Need").GetComponent<Text>();
        farm_E_use_txt = GameObject.Find("Energy_Farm_Con").GetComponent<Text>();

        raw_Mat_txt = GameObject.Find("Raw_Mat").GetComponent<Text>();
        bld_Mat_txt = GameObject.Find("Bld_Mat").GetComponent<Text>();
        con_Goods_txt = GameObject.Find("Con_Goods").GetComponent<Text>();
        ind_E_need_txt = GameObject.Find("Energy_Ind_Need").GetComponent<Text>();
        ind_E_use_txt = GameObject.Find("Energy_Ind_Con").GetComponent<Text>();

        tot_Pop_txt = GameObject.Find("Tot_Pop").GetComponent<Text>();
        attitude_txt = GameObject.Find("Attitude").GetComponent<Text>();
        provisions_Need_txt = GameObject.Find("Provisions_Need").GetComponent<Text>();
        provisions_Con_txt = GameObject.Find("Provisions_Con").GetComponent<Text>();
        con_Goods_need_txt = GameObject.Find("Con_Goods_Need").GetComponent<Text>();
        con_Goods_con_txt = GameObject.Find("Con_Goods_Con").GetComponent<Text>();
        pop_E_need_txt = GameObject.Find("Energy_Pop_Need").GetComponent<Text>();
        pop_E_use_txt = GameObject.Find("Energy_Pop_Con").GetComponent<Text>();

        Energy_Pot = energy_Pot_txt;
        Energy_Pro = energy_Pro_txt;

        Arable_Land = arable_Land_txt;
        Fertility = fertility_txt;
        Used_Land = used_Land_txt;
        Provisions_Pro = provisions_Pro_txt;
        Farm_E_Need = farm_E_need_txt;
        Farm_E_Use = farm_E_use_txt;

        Raw_Mat = raw_Mat_txt;
        Bld_Mat = bld_Mat_txt;
        Con_Goods = con_Goods_txt;
        Ind_E_Need = ind_E_need_txt;
        Ind_E_Use = ind_E_use_txt;

        Tot_Pop = tot_Pop_txt;
        Attitude = attitude_txt;
        Provisions_Need = provisions_Need_txt;
        Provisions_Con = provisions_Con_txt;
        Con_Goods_Need = con_Goods_need_txt;
        Con_Goods_Con = con_Goods_con_txt;
        Pop_E_Need = pop_E_need_txt;
        Pop_E_Use = pop_E_use_txt;
    }

}
