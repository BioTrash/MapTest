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
        Text arable_Land_txt, fertility_txt, used_Land_txt, provisions_Pro_txt, farm_E_need_txt, farm_E_use_txt;
        Text raw_Mat_txt, bld_Mat_txt, con_Goods_txt, ind_E_need_txt, ind_E_use_txt;
        Text tot_Pop_txt, attitude_txt, provisions_Need_txt, provisions_Con_txt, con_Goods_need_txt, con_Goods_con_txt, pop_E_need_txt, pop_E_use_txt;

        System.Random energy_Pot = new System.Random();
        System.Random arable_land = new System.Random();
        System.Random fertility = new System.Random();
        System.Random raw_Mat = new System.Random();

        int _energy_Pot = energy_Pot.Next(100000, 10000000);
        int _energy_Pro = 0; //To be modified, 0 as a place holder for now

        int _arable_Land = arable_land.Next(20000, 200000);
        int _fertility = fertility.Next(1, 75);
        int _used_Land = 0; //To be modified, 0 as a place holder for now
        int _provisions_Pro = 0; //To be modified 0 as a place holder for now
        int _farm_E_need = 0;//To be modified, 0 as a place holder for now
        int _farm_E_use = 0; //To be modified, 0 as a place holder for now

        int _raw_Mat = raw_Mat.Next(100, 1000);
        int _bld_Mat = 0; //To be modified, 0 as a place holder for now
        int _con_Goods = 0; //To be modified, 0 as a place holder for now
        int _ind_E_need = 0; //To be modified, 0 as a place holder for now
        int _ind_E_use = 0; //To be modified, 0 as a place holder for now

        int _tot_Pop = 0; //To be modified, 0 as a place holder for now
        int _attitude = 0; //To be modified, 0 as a place holder for now
        int _provisions_Need = 0; //To be modified, 0 as a place holder for now
        int _provisions_Con = 0; //To be modified, 0 as a place holder for now
        int _con_Goods_need = 0; //To be modified, 0 as a place holder for now
        int _con_Goods_con = 0; //To be modified, 0 as a place holder for now
        int _pop_E_need = 0; //To be modified, 0 as a place holder for now
        int _pop_E_use = 0; //To be modified, 0 as a place holder for now

        energy_Pot_txt = GameObject.Find("Energy_Pot").GetComponent<Text>();
        energy_Pot_txt.text = Convert.ToString(_energy_Pot);
        string savePotValue = "" + Convert.ToString(_energy_Pot);
        energy_Pro_txt = GameObject.Find("Energy_Pro").GetComponent<Text>();
        energy_Pro_txt.text = Convert.ToString(_energy_Pro);
        string saveProValue = "" + Convert.ToString(_energy_Pro);

        arable_Land_txt = GameObject.Find("Arable_Land").GetComponent<Text>();
        arable_Land_txt.text = Convert.ToString(_arable_Land);
        string saveArableValue = "" + Convert.ToString(_arable_Land);
        fertility_txt = GameObject.Find("Fertility").GetComponent<Text>();
        fertility_txt.text = Convert.ToString(_fertility);
        string saveFertilityValue = "" + Convert.ToString(_fertility);
        used_Land_txt = GameObject.Find("Cultivated_Land").GetComponent<Text>();
        used_Land_txt.text = Convert.ToString(_used_Land);
        string saveUsedValue = "" + Convert.ToString(_used_Land);
        provisions_Pro_txt = GameObject.Find("Provisions_Pro").GetComponent<Text>();
        provisions_Pro_txt.text = Convert.ToString(_provisions_Pro);
        string savePProValue = "" + Convert.ToString(_provisions_Pro);
        farm_E_need_txt = GameObject.Find("Energy_Farm_Need").GetComponent<Text>();
        farm_E_need_txt.text = Convert.ToString(_farm_E_need);
        string saveFEValue = "" + Convert.ToString(_farm_E_need);
        farm_E_use_txt = GameObject.Find("Energy_Farm_Con").GetComponent<Text>();
        farm_E_use_txt.text = Convert.ToString(_farm_E_use);
        string saveFUValue = "" + Convert.ToString(_farm_E_use);

        raw_Mat_txt = GameObject.Find("Raw_Mat").GetComponent<Text>();
        raw_Mat_txt.text = Convert.ToString(_raw_Mat);
        string saveRawValue = "" + Convert.ToString(_raw_Mat);
        bld_Mat_txt = GameObject.Find("Bld_Mat").GetComponent<Text>();
        bld_Mat_txt.text = Convert.ToString(_bld_Mat);
        string saveBldValue = "" + Convert.ToString(_bld_Mat);
        con_Goods_txt = GameObject.Find("Con_Goods").GetComponent<Text>();
        con_Goods_txt.text = Convert.ToString(_con_Goods);
        string saveGoodsValue = "" + Convert.ToString(_con_Goods);
        ind_E_need_txt = GameObject.Find("Energy_Ind_Need").GetComponent<Text>();
        ind_E_need_txt.text = Convert.ToString(_ind_E_need);
        string saveINValue = "" + Convert.ToString(_ind_E_need);
        ind_E_use_txt = GameObject.Find("Energy_Ind_Con").GetComponent<Text>();
        ind_E_use_txt.text = Convert.ToString(_ind_E_use);
        string saveIUValue = "" + Convert.ToString(_ind_E_use);

        tot_Pop_txt = GameObject.Find("Tot_Pop").GetComponent<Text>();
        tot_Pop_txt.text = Convert.ToString(_tot_Pop);
        string savePopValue = "" + Convert.ToString(_tot_Pop);
        attitude_txt = GameObject.Find("Attitude").GetComponent<Text>();
        attitude_txt.text = Convert.ToString(_attitude);
        string saveAttitudeValue = "" + Convert.ToString(_attitude);
        provisions_Need_txt = GameObject.Find("Provisions_Need").GetComponent<Text>();
        provisions_Need_txt.text = Convert.ToString(_provisions_Need);
        string saveProvNeedValue = "" + Convert.ToString(_provisions_Need);
        provisions_Con_txt = GameObject.Find("Provisions_Con").GetComponent<Text>();
        provisions_Con_txt.text = Convert.ToString(_provisions_Con);
        string saveProvConValue = "" + Convert.ToString(_provisions_Con);
        con_Goods_need_txt = GameObject.Find("Con_Goods_Need").GetComponent<Text>();
        con_Goods_need_txt.text = Convert.ToString(_con_Goods_need);
        string saveGNValue = "" + Convert.ToString(_con_Goods_need);
        con_Goods_con_txt = GameObject.Find("Con_Goods_Con").GetComponent<Text>();
        con_Goods_con_txt.text = Convert.ToString(_con_Goods_con);
        string saveGCValue = "" + Convert.ToString(_energy_Pro);
        pop_E_need_txt = GameObject.Find("Energy_Pop_Need").GetComponent<Text>();
        pop_E_need_txt.text = Convert.ToString(_pop_E_need);
        string savePNValue = "" + Convert.ToString(_pop_E_need);
        pop_E_use_txt = GameObject.Find("Energy_Pop_Con").GetComponent<Text>();
        pop_E_use_txt.text = Convert.ToString(_pop_E_use);
        string savePUValue = "" + Convert.ToString(_pop_E_use);

        string saveSeparator = "//";
        string[] contents = new string[]
        {
            ""+savePotValue,
            ""+saveProValue,
            ""+saveArableValue,
            ""+saveFertilityValue,
            ""+saveUsedValue,
            ""+savePProValue,
            ""+saveFEValue,
            ""+saveFUValue,
            ""+saveRawValue,
            ""+saveBldValue,
            ""+saveGoodsValue,
            ""+saveINValue,
            ""+saveIUValue,
            ""+savePopValue,
            ""+saveAttitudeValue,
            ""+saveProvNeedValue,
            ""+saveProvConValue,
            ""+saveGNValue,
            ""+saveGCValue,
            ""+savePNValue,
            ""+savePUValue
        };
        string saveString = string.Join(saveSeparator, contents);

        saveStringReal = saveString;
    }
}
