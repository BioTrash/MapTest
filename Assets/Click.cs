using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public const string saveSeparator = "//";

    public Button Button0, Button1, Button2, Button3;
    public GameObject MapSideUI, EnergyUI, PopulationUI, FarmingUI, IndustryUI;
    public GameObject BldUI_E, BldUI_P, BldUI_F, BldUI_I;

    private void Start()
    {
        Button btn = Button0.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);

        Button btn1 = Button1.GetComponent<Button>();
        btn1.onClick.AddListener(OnClick1);

        Button btn2 = Button2.GetComponent<Button>();
        btn2.onClick.AddListener(OnClick2);

        Button btn3 = Button3.GetComponent<Button>();
        btn3.onClick.AddListener(OnClick3);
    }
    private void OnClick()
    {
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        EnergyUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        PopulationUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        FarmingUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        IndustryUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        BldUI_E.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_P.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_F.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_I.transform.position = new Vector3(Convert.ToSingle(4000), -711);


        if (File.Exists(Application.dataPath + "/SaveTxt/ValueSave/save.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/ValueSave/save.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            ResourceScriptLoad Load = new ResourceScriptLoad();

            Load.Energy_Pot.text = content[0];
            Load.Energy_Pro.text = content[1];
        }
        else
        {
            ResourceScript Save = new ResourceScript();

            File.WriteAllText(Application.dataPath + "/SaveTxt/ValueSave/save.txt", Save.saveStringReal);
        }
    }

    private void OnClick1()
    {
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        EnergyUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        PopulationUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        FarmingUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        IndustryUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        BldUI_E.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_P.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_F.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_I.transform.position = new Vector3(Convert.ToSingle(4000), -711);

        if (File.Exists(Application.dataPath + "/SaveTxt/ValueSave/save1.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/ValueSave/save1.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            ResourceScriptLoad Load = new ResourceScriptLoad();

            Load.Energy_Pot.text = content[0];
            Load.Energy_Pro.text = content[1];
        }
        else
        {
            ResourceScript Save = new ResourceScript();

            File.WriteAllText(Application.dataPath + "/SaveTxt/ValueSave/save1.txt", Save.saveStringReal);
        }
    }

    private void OnClick2()
    {
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        EnergyUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        PopulationUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        FarmingUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        IndustryUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        BldUI_E.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_P.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_F.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_I.transform.position = new Vector3(Convert.ToSingle(4000), -711);

        if (File.Exists(Application.dataPath + "/SaveTxt/ValueSave/save2.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/ValueSave/save2.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            ResourceScriptLoad Load = new ResourceScriptLoad();

            Load.Energy_Pot.text = content[0];
            Load.Energy_Pro.text = content[1];
        }
        else
        {
            ResourceScript Save = new ResourceScript();

            File.WriteAllText(Application.dataPath + "/SaveTxt/ValueSave/save2.txt", Save.saveStringReal);
        }
    }

    private void OnClick3()
    {
        MapSideUI.transform.position = new Vector3(Convert.ToSingle(2028.5), 0);
        EnergyUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        PopulationUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        FarmingUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        IndustryUI.transform.position = new Vector3(Convert.ToSingle(2928.5), 0);
        BldUI_E.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_P.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_F.transform.position = new Vector3(Convert.ToSingle(4000), -711);
        BldUI_I.transform.position = new Vector3(Convert.ToSingle(4000), -711);

        if (File.Exists(Application.dataPath + "/SaveTxt/ValueSave/save3.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/ValueSave/save3.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            ResourceScriptLoad Load = new ResourceScriptLoad();

            Load.Energy_Pot.text = content[0];
            Load.Energy_Pro.text = content[1];
        }
        else
        {
            ResourceScript Save = new ResourceScript();

            File.WriteAllText(Application.dataPath + "/SaveTxt/ValueSave/save3.txt", Save.saveStringReal);
        }
    }
}
